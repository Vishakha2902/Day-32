using Microsoft.EntityFrameworkCore;
using EF_DB_Connect_Demo.Data;
using EF_DB_Connect_Demo.Models;
using EF_DB_Connect.Data;

namespace EF_DB_Connect_Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TrainingContext>();
            optionsBuilder.UseSqlServer(
                @"Data Source=LAPTOP-4ALE1NRQ\SQLEXPRESS02;Initial Catalog=day32;Integrated Security=True;Trust Server Certificate=True"
            );

            using (var context = new TrainingContext(optionsBuilder.Options))
            {
                // Perform database operations using the context
                if (!context.Students.Any())
                {
                    var trainer = new Trainer 
                    { 
                        Name = "John Doe" 
                    };

                    var student = new Student 
                    { 
                        Name = "Jane Smith", 
                        Age = 22, 
                        Email = "jane.smith@example.com"
                    };

                    var course = new Course 
                    { 
                        Title = "C# Basics", 
                        Trainer = trainer 
                    };

                    context.Students.Add(student);
                    context.Courses.Add(course);
                    context.Trainers.Add(trainer);

                    context.SaveChanges();
                    Console.WriteLine("Data seeded successfully.");
                }
                else
                {
                    Console.WriteLine("Data already exists in the database.");
                }
            }
        }
    }
}
