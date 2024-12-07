using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ParallelProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        // DbSets for the models
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuizResult> QuizResults { get; set; }
        public DbSet<Answer> Answers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source = LAPTOP-EPP1LDGQ\\MSSQLSERVER04; Initial Catalog = QuizSystem; Integrated Security = True; TrustServerCertificate = True");
            //optionsBuilder.UseSqlServer("Data Source = .; Initial Catalog = QuizSystem; Integrated Security = True; TrustServerCertificate = True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Example: Seed Roles
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Admin" },
                new Role { Id = 2, Name = "User" }
            );

            // Configure relationships if not using conventions
            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId);

            modelBuilder.Entity<Question>()
                .HasOne(q => q.Quiz)
                .WithMany(quiz => quiz.Questions)
                .HasForeignKey(q => q.QuizId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<QuizResult>()
                .HasOne(qr => qr.User)
                .WithMany(u => u.QuizResults)
                .HasForeignKey(qr => qr.UserId);

            modelBuilder.Entity<QuizResult>()
                .HasOne(qr => qr.Quiz)
                .WithMany()
                .HasForeignKey(qr => qr.Quiz_Id)
                .OnDelete(DeleteBehavior.Restrict);
               

            // QuizResult to Answer relationship
            modelBuilder.Entity<Answer>()
                .HasOne(a => a.QuizResult)
                .WithMany(qr => qr.Answers)
                .HasForeignKey(a => a.QuizResultId)
                .OnDelete(DeleteBehavior.Restrict);

            // Question to Answer relationship
            modelBuilder.Entity<Answer>()
                .HasOne(a => a.Question)
                .WithMany()
                .HasForeignKey(a => a.QuestionId);

           

            base.OnModelCreating(modelBuilder);

        }
    }
}
