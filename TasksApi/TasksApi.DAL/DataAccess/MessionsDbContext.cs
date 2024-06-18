using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksApi.Models.Entities;

namespace TasksApi.DAL.DataAccess
{
    public partial class MessionsDbContext : DbContext
    {
        public MessionsDbContext()
        {
        }

        public MessionsDbContext(DbContextOptions<MessionsDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Mession> Messions { get; set; }

        public virtual DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQL2019EXPRESS;Database=MessionsDB;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mession>(entity =>
            {
                entity.HasKey(e => e.TaskId).HasName("PK_Tasks");

                entity.Property(e => e.TaskId).ValueGeneratedOnAdd().Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Throw);
                entity.Property(e => e.IsCompleted).HasColumnName("isCompleted");
                entity.Property(e => e.Subject)
                    .HasMaxLength(250)
                    .HasColumnName("subject");
                entity.Property(e => e.TargetDate)
                    .HasColumnType("datetime")
                    .HasColumnName("targetDate");
                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("userId");
                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
