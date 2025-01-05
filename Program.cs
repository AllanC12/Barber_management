using BarberManagement.data;
using BarberManagement.Helpers;
using BarberManagement.Repository;
using BarberManagement.Repository.Interfaces;
using BarberManagement.Services;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.Common;

var builder = WebApplication.CreateBuilder(args);

    var pathArchive = Path.Combine(Directory.GetCurrentDirectory(), "Connection.ini");
    var retorno = ConnectionRead.ReadArchiveConnection(pathArchive);

    // Definindo vari�veis de configura��o
    var ip = retorno.GetValueOrDefault("IP", "default");
    var sgbd = retorno.GetValueOrDefault("SGBD", "default");
    var user = retorno.GetValueOrDefault("USER", "default");
    var port = retorno.GetValueOrDefault("PORT", "default");
    var database = retorno.GetValueOrDefault("DATABASE", "default");
    var password = retorno.GetValueOrDefault("PASSWORD","default");


// String de conex�o
var connectionString = sgbd.ToUpper() switch
{
    "MYSQL" => $"server={ip};port={port};user={user};password={password};database={database}",
    "POSTGRES" => $"Host={ip};Port={port};Username={user};Password={password};Database={database}",
    _ => throw new NotSupportedException($"Tipo de banco de dados '{sgbd}' n�o suportado.")
};

// Configura o DbContext
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

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IBarberAdminRepository, BarberAdminRepository>();

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IUnityOfWork, UnityOfWork>();
builder.Services.AddScoped<ISearchClientService, SearchClientService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();

// Usando o middleware
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();