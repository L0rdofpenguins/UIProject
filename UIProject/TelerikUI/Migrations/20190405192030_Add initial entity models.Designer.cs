﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TelerikUI.Repository;

namespace TelerikUI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190405192030_Add initial entity models")]
    partial class Addinitialentitymodels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TelerikUI.Models.Material", b =>
                {
                    b.Property<string>("MaterialName")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Manufacturer");

                    b.HasKey("MaterialName");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("TelerikUI.Models.Order", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("FinishDate");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("TelerikUI.Models.SystemMaterial", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MaterialName");

                    b.Property<string>("SN")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("SystemId");

                    b.HasKey("Id");

                    b.HasIndex("MaterialName");

                    b.HasIndex("SystemId");

                    b.ToTable("SystemMaterials");
                });

            modelBuilder.Entity("TelerikUI.Models.SystemSerial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId");

                    b.Property<string>("OrderId1");

                    b.HasKey("Id");

                    b.HasIndex("OrderId1");

                    b.ToTable("SystemSerials");
                });

            modelBuilder.Entity("TelerikUI.Models.SystemMaterial", b =>
                {
                    b.HasOne("TelerikUI.Models.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialName");

                    b.HasOne("TelerikUI.Models.SystemSerial", "System")
                        .WithMany()
                        .HasForeignKey("SystemId");
                });

            modelBuilder.Entity("TelerikUI.Models.SystemSerial", b =>
                {
                    b.HasOne("TelerikUI.Models.Order", "Order")
                        .WithMany("SystemSerials")
                        .HasForeignKey("OrderId1");
                });
#pragma warning restore 612, 618
        }
    }
}
