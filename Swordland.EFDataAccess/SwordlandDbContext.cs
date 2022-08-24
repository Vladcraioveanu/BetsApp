using Microsoft.EntityFrameworkCore;
using Swordland.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Swordland.EFDataAccess
{
    public class SwordlandDbContext : DbContext
    {
        public SwordlandDbContext(DbContextOptions<SwordlandDbContext> options)
           : base(options)
        {
        }
        public DbSet<Enroll> Enrolls { get; set; }
        public DbSet<Bet> Bets { get; set; }
        public DbSet<Challengers> Challengers { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Enroll>().HasKey(t => t.EnrollId);
            modelBuilder.Entity<Bet>().HasKey(t => t.BetId);
            modelBuilder.Entity<Challengers>().HasKey(t => t.ChallengeId);
            modelBuilder.Entity<Tickets>().HasKey(t => t.TicketsId);
            modelBuilder.Entity<User>().HasKey(t => t.UserId);

            modelBuilder.Entity<Bet>()
                .HasOne(t => t.Challenger)
                .WithMany(t => t.Bets)
                .HasForeignKey(f => f.ChallengerId);

            modelBuilder.Entity<Tickets>()
                .HasOne(t => t.Users)
                .WithMany(t => t.Tickets)
                .HasForeignKey(f => f.UserId);

            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
