using Microsoft.EntityFrameworkCore;
using Sandberg.Share.Models;
using System;

namespace Sandberg.Data.Contexts
{
    public class SandbergContext : DbContext
    {
        public string DbPath { get; private set; }

        public SandbergContext()
        {
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source=sandberg.db");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoggingModel>().ToTable("LoggingModels");            
        }

        public DbSet<LoggingModel> LoggingModels { get; set; }
    }
}