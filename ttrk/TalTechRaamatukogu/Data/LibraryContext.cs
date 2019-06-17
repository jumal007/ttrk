using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TalTechRaamatukogu.Models;

namespace TalTechRaamatukogu.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("Book");
            modelBuilder.Entity<Customer>().ToTable("Customer");
        }
    }
}
