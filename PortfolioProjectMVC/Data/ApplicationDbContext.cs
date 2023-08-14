using Microsoft.EntityFrameworkCore;
using PortfolioProjectMVC.Models;

namespace PortfolioProjectMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<PortfolioProjectMVC.Models.Book>? Book { get; set; }

        public DbSet<PortfolioProjectMVC.Models.Author>? Author { get; set; }

        public DbSet<PortfolioProjectMVC.Models.Publisher>? Publisher { get; set; }

        public DbSet<PortfolioProjectMVC.Models.Genre>? Genre { get; set; }

    }
}
