﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=MyNorthwind;Trusted_Connection=true");
        }
        public DbSet<Car> CARS { get; set; }
        public DbSet<Brand> BRANDS { get; set; }
        public DbSet<Color> COLORS { get; set; }
        public DbSet<Customer> CUSTOMERS { get; set; }
        public DbSet<User> USERS { get; set; }
        public DbSet<Rental> RENTALS { get; set; }
    }
}
