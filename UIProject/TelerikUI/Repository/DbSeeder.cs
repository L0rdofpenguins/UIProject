using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelerikUI.Models;

namespace TelerikUI.Repository
{
    public static class DbSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            OrderSeeder(modelBuilder);
            SystemSerialSeeder(modelBuilder);
            MaterialSeeder(modelBuilder);
            SystemMaterialSeeder(modelBuilder);
        }

        public static void OrderSeeder(this ModelBuilder modelBuilder)
        {
            for (int i = 1; i <= 10; i++) {
                modelBuilder.Entity<Order>().HasData(

                    new Order { OrderId = i.ToString(), StartDate = DateTime.Now }

                    );
            }
        }

        public static void SystemSerialSeeder(this ModelBuilder modelBuilder)
        {
            for (int i = 1; i <= 10; i++)
            {
                modelBuilder.Entity<SystemSerial>().HasData(
                    new SystemSerial { OrderId=i.ToString(), SystemSerialId = i}
                    );
            }
        }

        public static void SystemMaterialSeeder(this ModelBuilder modelBuilder)
        {
            for (int i = 1; i <= 10; i++)
            {
                modelBuilder.Entity<SystemMaterial>().HasData(
                    new SystemMaterial { SystemMaterialId = Guid.NewGuid(), MaterialName = i.ToString(), SystemSerialId = i });
            }
        }

        public static void MaterialSeeder(this ModelBuilder modelBuilder)
        {
            for (int i = 1; i <= 10; i++)
            {
                modelBuilder.Entity<Material>().HasData(
                    new Material { MaterialName = i.ToString(), Manufacturer="Advantech" }
                    );
            }
        }
    }
}
