using BarberManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace BarberManagement.data

{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<BarberAdminModel> BarberAdmin { get; set; }
        public DbSet<AgendaModel> BarberAgenda { get; set; }
        public DbSet<ClientModel> Clients { get; set; }
        public DbSet<BarberServiceModel> BarberService { get; set; }


    }
}