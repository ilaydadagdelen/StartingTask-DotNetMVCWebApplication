using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace StartingTask.Models
{
    public partial class IMPStartingTaskDB : DbContext
    {
        public IMPStartingTaskDB()
            : base("name=IMPStartingTaskDB")
        {
        }

        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<UserSignup> UserSignups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subject>()
                .Property(e => e.Group)
                .IsUnicode(false);

            modelBuilder.Entity<Subject>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Subject>()
                .Property(e => e.Link)
                .IsUnicode(false);

            modelBuilder.Entity<Subject>()
                .Property(e => e.Lesson)
                .IsUnicode(false);

            modelBuilder.Entity<UserSignup>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<UserSignup>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<UserSignup>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
