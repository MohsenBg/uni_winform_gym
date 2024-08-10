using GymApp.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace GymApp.Data
{
    public class GymContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }

        public DbSet<Attendance> Attendances { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GymApp.db");
            optionsBuilder.UseSqlite($"Data Source={path};foreign keys=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.UserId);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Subscription)
                .WithOne(s => s.User)
                .HasForeignKey<Subscription>(s => s.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            var users = Seed.GetUsers();
            var subscriptions = Seed.GetSubscriptions(users);
            var attendances = Seed.GetAttendances(users);

            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Subscription>().HasData(subscriptions);
            modelBuilder.Entity<Attendance>().HasData(attendances);
        }
    }
}