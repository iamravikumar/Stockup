using System;
using Microsoft.EntityFrameworkCore;
using StockUpBL.Models;


namespace StockUpDAL
{
    public class AppDbContext : DbContext
    {

        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DotNetEnv.Env.Load("../.env");
            string connectionStringEnv = DotNetEnv.Env.GetString("CONNECTION_STRING");
            System.Diagnostics.Debug.WriteLine(connectionStringEnv);

            // var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\parsa\OneDrive\Documents\StockUpDB.mdf;Integrated Security=True;Connect Timeout=30";
            // optionsBuilder.UseSqlServer(connectionString);
        }

    }
}
