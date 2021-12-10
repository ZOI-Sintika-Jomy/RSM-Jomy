using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using RSM.BAL.DomainModels.Models;

namespace RSM.BAL.DBContextZoi
{
    public class DBContextZoi:DbContext
    {
        //protected IConfiguration _configuration { get; set; }

        public DBContextZoi()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string ConnectionStringSSON = string.Empty;
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
           // configurationBuilder.AddJsonFile(path, false);

            var root = configurationBuilder.Build();
            ConnectionStringSSON = root.GetConnectionString("DBContextZoi");

           // optionsBuilder.UseSqlServer(ConnectionStringSSON);
        }

        public DBContextZoi(DbContextOptions<DBContextZoi> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
            .HasKey(ur => new { ur.Id });

        }

        internal object Repository<T>()
        {
            throw new NotImplementedException();
        }
    }
}
