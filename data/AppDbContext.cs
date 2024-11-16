using Microsoft.EntityFrameworkCore;
using BarberManagement.Models;

namespace BarberManagement.data

{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){

        }

        public DbSet<BarberAdminModel> BarberAdmin {get; set;}
        public DbSet<AgendaModel> BarberAgenda {get; set;}
        public DbSet<CustomerModel> Customers {get; set;}
        public DbSet<BarberServiceModel> BarberService {get; set;}



    }
}