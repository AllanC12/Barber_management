using System.Security.Cryptography;
using BarberManagement.data;
using BarberManagement.Helpers;
using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


var connectionPath = Path.Combine(Directory.GetCurrentDirectory(), "Connection.ini");
var configs = ConnectionRead.ReadArchiveConnection(connectionPath);

var ip = configs.GetValueOrDefault("IP", "localhost");
var sgbd = configs.GetValueOrDefault("SGBD", "MYSQL");
var user = configs.GetValueOrDefault("USER", "root");   
var password = configs.GetValueOrDefault("PASSWORD", "allan007");   
var port = configs.GetValueOrDefault("PORT", "3306");
var database = configs.GetValueOrDefault("DATABASE", "barbermanagement");

var connectionString = sgbd.ToUpper() switch
{
    "MYSQL" => $"server={ip};port={port};user={user};password=allan007;database={database}",
    "POSTGRES" => $"Host={ip};Port={port};Username={user};Password=allan007;database={database}",
    _ => throw new NotSupportedException($"Tipo de banco de dados '{sgbd}' não suportado")

};


builder.Services.AddDbContext<AppDbContext>(options =>
{

    if (sgbd == "MYSQL")
    {
        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }
    else if (sgbd == "POSTGRES")
    {
        options.UseNpgsql(connectionString);
    }

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();
