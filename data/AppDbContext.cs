using Microsoft.EntityFrameworkCore;
using BarberManagement.Models;

namespace BarberManagement.data

{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){

        }

        public DbSet<AdmModel> BarberAdmin {get; set;}
        public DbSet<AgendaModel> BarberAgenda {get; set;}
        public DbSet<ClientModel> Customers {get; set;}
        public DbSet<ServicesModel> BarberService {get; set;}



    }
}