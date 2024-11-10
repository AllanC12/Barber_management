using Microsoft.EntityFrameworkCore;
using BarberManagement.Models;

namespace BarberManagement.data

{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){

        }

        public DbSet<AdmModel> Admin {get; set;}
        public DbSet<AgendaModel> Agenda {get; set;}
        public DbSet<ClientModel> Client {get; set;}
        public DbSet<ServicesModel> Services {get; set;}



    }
}