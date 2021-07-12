using ArandaData.Connection.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ArandaData.Connection
{
    public class ArandaDbContext : DbContext
    {
        private static string database = "Aranda.db";

        public DbSet<PropertiesMachine> propertiesMachines { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            optionbuilder.UseSqlite(connectionString: "Filename ="+database,
                sqliteOptionsAction: op => 
                {
                    op.MigrationsAssembly(
                        Assembly.GetExecutingAssembly().FullName
                        );
                });

            base.OnConfiguring(optionbuilder);
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PropertiesMachine>().ToTable("PropertiesMachines");
            modelBuilder.Entity<PropertiesMachine>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            base.OnModelCreating(modelBuilder);
        }

        public static ArandaDbContext Create()
        {
            return new ArandaDbContext();
        }
    }
}
