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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        public DbSet<User> User {get; set; }
        public DbSet<Executor> Executor {  get; set; }
        public DbSet <Responsible> Responsible { get; set; }
        public DbSet<Request> Request { get; set; }
        public DbSet<Technic> Technic { get; set; }
        public DbSet<TypeTechnic> TypeTechnic { get; set; }
        public DbSet<Shop> Shop { get; set; }
        public DbSet<Place> Place { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Technic>()
                .HasOne(m => m.request)
                .WithMany(t => t.technic)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Request>()
            .HasMany(m => m.technic)
            .WithOne(t => t.request)
            .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
