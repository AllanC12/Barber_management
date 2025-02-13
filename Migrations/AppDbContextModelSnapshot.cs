﻿// <auto-generated />
using System;
using BarberManagement.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BarberManagement.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BarberManagement.Models.AgendaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AdmModelId")
                        .HasColumnType("int");

                    b.Property<int>("ClientModelId")
                        .HasColumnType("int");

                    b.Property<int>("ServicesModelId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeService")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("BarberAgenda");
                });

            modelBuilder.Entity("BarberManagement.Models.BarberAdminModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Annotations")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Especializations")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NameAdm")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PasswordAdm")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("BarberAdmin");
                });

            modelBuilder.Entity("BarberManagement.Models.BarberServiceModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("ServicePrice")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("BarberService");
                });

            modelBuilder.Entity("BarberManagement.Models.ClientModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateOnly>("Birthday")
                        .HasColumnType("date");

                    b.Property<string>("Favorite_Service")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Observation")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });
#pragma warning restore 612, 618
        }
    }
}
