using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;
using moment3cdsamling.Models;

namespace moment3cdsamling.Data
{
    // Database context class
    public class DataContext : DbContext
    {
        // Constructor
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        }

        // Tables
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Loan> Loans { get; set; }
    }
}
