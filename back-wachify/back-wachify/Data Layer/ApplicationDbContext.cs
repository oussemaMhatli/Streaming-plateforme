﻿using back_wachify.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace back_wachify.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Film> Film { get; set; }



        public DbSet<User> User { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);
            modelBuilder.Entity<User>()
            .HasIndex(u => u.Username)
            .IsUnique();
        }


    }
}
