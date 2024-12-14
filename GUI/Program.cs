using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ParallelProject.Data;
using ParallelProject.Services;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Configure the DbContextOptions
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Data Source = LAPTOP-EPP1LDGQ\\MSSQLSERVER04; Initial Catalog = QuizSystem; Integrated Security = True; TrustServerCertificate = True");

            // Create the IDbContextFactory using the options
            var dbContextFactory = new PooledDbContextFactory<ApplicationDbContext>(optionsBuilder.Options);

            

            // Pass the factory to the Quizzilles form
            ApplicationConfiguration.Initialize();
            Application.Run(new Quizzilles(dbContextFactory));
        }
    }
}
