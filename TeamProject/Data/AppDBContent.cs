using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Data.Models;

namespace TeamProject.Data
{
    public class AppDBContent: DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base (options)
        {

        }

        public DbSet<User> User { get; }
        public DbSet<Executor> Executor { get; }
        public DbSet <Responsible> Responsible { get; }
        public DbSet<Request> Request { get; set; }
        public DbSet<Technic> Technic { get; }
        public DbSet<TypeTechnic> TypeTechnic { get; }
        public DbSet<Shop> Shop { get; }
        public DbSet<Place> Place { get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shop>().Ignore(b => b.requests);
            modelBuilder.Entity<TypeTechnic>().Ignore(b => b.technics);
        }
    }
}
