
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using VehWebApp.DataLayer;
using VehWebApp.Models.Vehicles;

namespace VehWebApp.Migrations.SeedData
{
    public static class InitDataSeed
    {
        /// <summary>
        ///     Seeding the initial data.
        /// </summary>
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<VehDbContext>();

            if (context.Database == null)
            {
                throw new Exception("DB is null");
            }

            if (context.Vehicles.Any())
            {
                return;   // DB has been seeded
            }

            context.Vehicles.AddRange(
                 new UsedVehicle
                 {
                     Code = "dm",
                     Name = "Mazda Demio",
                     IssueDate = DateTime.Parse("2011-04-03"),
                     Description = "Mazda 2 - Driving Matters",
                     BasePrice = 0.4M,                     
                     Kilometres = 100001,
                     PurchaseDate = DateTime.Parse("2012-03-18")
                     
                 },

                 new UsedVehicle
                 {
                     Code = "bm",
                     Name = "BMW X1",
                     IssueDate = DateTime.Parse("2012-03-03"),
                     Description = "BMW - Sheer Driving Pleasure and Joy",
                     BasePrice = 1.01M,                     
                     Kilometres = 13244,
                     PurchaseDate = DateTime.Parse("2013-03-18")
                 },

                 new UsedVehicle
                 {
                     Code = "bm",
                     Name = "BMW X1",
                     IssueDate = DateTime.Parse("2014-08-03"),
                     Description = "BMW - Sheer Driving Pleasure and Joy",
                     BasePrice = 0.5M,
                     Kilometres = 13244,
                     PurchaseDate = DateTime.Parse("2016-03-18")
                 },

                new UsedVehicle
                {
                    Code = "dm",
                    Name = "Mazda Demio",
                    IssueDate = DateTime.Parse("2005-03-03"),
                    Description = "Mazda 2 - Driving Matters",
                    BasePrice = 0.001M,
                    Kilometres = 45754,
                    PurchaseDate = DateTime.Parse("2016-04-02")
                }
            );
            context.SaveChanges();
        }
    }
}