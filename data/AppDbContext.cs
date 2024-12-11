using Microsoft.EntityFrameworkCore;
using BarberManagement.Models;
using System.ComponentModel;

namespace BarberManagement.data

{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<BarberAdminModel> BarberAdmin { get; set; }
        public DbSet<AgendaModel> BarberAgenda { get; set; }
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<BarberServiceModel> BarberService { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerModel>()
                .Property(c => c.Birthday)
                .HasConversion(
                    dateOnly => dateOnly.ToDateTime(TimeOnly.MinValue),
                    dateTime => DateOnly.FromDateTime(dateTime))
                .HasColumnType("date");
        }

    }
}