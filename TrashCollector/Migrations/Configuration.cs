namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TrashCollector.Models;


    internal sealed class Configuration : DbMigrationsConfiguration<TrashCollector.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TrashCollector.Models.ApplicationDbContext context)
        {
            context.Customer.AddOrUpdate(x => x.ID,
                new Customers() { ID = 3, PickupDay = "Monday", ZipCode = 53151 },
                new Customers() { ID = 4, PickupDay = "Wednesday", ZipCode = 53151 },
                new Customers() { ID = 5, PickupDay = "Friday", ZipCode = 53151 },
                new Customers() { ID = 6, PickupDay = "Friday", ZipCode = 53151 },
                new Customers() { ID = 7, PickupDay = "Tuesday", ZipCode = 53151 },
                new Customers() { ID = 8, PickupDay = "Monday", ZipCode = 53151 },
                new Customers() { ID = 9, PickupDay = "Monday", ZipCode = 53151 },
                new Customers() { ID = 10, PickupDay = "Monday", ZipCode = 53151 },
                new Customers() { ID = 11, PickupDay = "Friday", ZipCode = 53151 },
                new Customers() { ID = 12, PickupDay = "Friday", ZipCode = 53151 },
                new Customers() { ID = 13, PickupDay = "Thursday", ZipCode = 53151 },
                new Customers() { ID = 14, PickupDay = "Tuesday", ZipCode = 53151 },
                new Customers() { ID = 15, PickupDay = "Thursday", ZipCode = 53151 }
                );
                
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
