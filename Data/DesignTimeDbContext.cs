using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Design;
using EF_DB_Connect.Data;


namespace EF_DB_Connect_Demo.Data
{
    public class DesignTimeDbContext : IDesignTimeDbContextFactory<TrainingContext>
    {
        public EF_DB_Connect.Data.TrainingContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TrainingContext>();
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-4ALE1NRQ\SQLEXPRESS02;Initial Catalog=day32;Integrated Security=True;Trust Server Certificate=True");
            return new TrainingContext(optionsBuilder.Options);
        }
    }
}