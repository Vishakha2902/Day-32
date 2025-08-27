using Microsoft.EntityFrameworkCore;

using EF_DB_Connect_Demo.Models;
using EF_DB_Connect_Demo.Data;

namespace EF_DB_Connect.Data
{
    public class TrainingContext : DbContext
    {
        public TrainingContext(DbContextOptions<TrainingContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }//Db Context class is used to interact with the database
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Course> Courses { get; set; }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     base.OnModelCreating(modelBuilder);

        //     // Configure relationships and constraints if needed
        //     modelBuilder.Entity<Course>()
        //         .HasOne(c => c.Trainer)
        //         .WithMany()
        //         .HasForeignKey(c => c.TrainerID)
        //         .OnDelete(DeleteBehavior.Cascade);
        // }
    }
}