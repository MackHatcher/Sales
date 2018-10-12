namespace SalesApp.Migrations
{
    using SalesApp.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SalesApp.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SalesApp.Models.ApplicationDbContext context)
        {
            var toothbrush = new ProductModel();
            toothbrush.Id = 1;
            toothbrush.Name = "Toothbrush";
            context.Products.AddOrUpdate(toothbrush);

            var toothpaste = new ProductModel();
            toothpaste.Id = 2;
            toothpaste.Name = "Toothpaste";
            context.Products.AddOrUpdate(toothpaste);

            var towel = new ProductModel();
            towel.Id = 3;
            towel.Name = "Towel";
            context.Products.AddOrUpdate(towel);

            var tom = new CustomerModel();
            tom.Id = 1;
            tom.Name = "Tom";
            context.Customers.AddOrUpdate(tom);

            var jerry = new CustomerModel();
            jerry.Id = 2;
            jerry.Name = "Jerry";
            context.Customers.AddOrUpdate(jerry);

            var jeff = new EmployeeModel();
            jeff.Id = 1;
            jeff.Name = "Tom";
            context.Employees.AddOrUpdate(jeff);

            var alex = new EmployeeModel();
            alex.Id = 2;
            alex.Name = "Tom";
            context.Employees.AddOrUpdate(alex);

            var superStore = new StoreLocationModel();
            superStore.Id = 1;
            superStore.LocationName = "Super Store";
            context.Stores.AddOrUpdate(superStore);

            var walMart = new StoreLocationModel();
            walMart.Id = 1;
            walMart.LocationName = "Wal-Mart";
            context.Stores.AddOrUpdate(walMart);

            var newSale = new SaleModel();
            newSale.Id = 1;
            newSale.Date = DateTime.Now;
            newSale.EmployeeId = 3;
            newSale.CustomerId = 4;
            newSale.StoreId = 2;
            context.Sales.AddOrUpdate(newSale);
        }
    }
}
