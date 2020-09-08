using Microsoft.EntityFrameworkCore;
using QuizzApp.Web.Models;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace QuizzApp.Web.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<QuizzQuestion> Questions { get; set; }

        public DbSet<QuizzAnswer> Answers { get; set; }

        public AppDbContext([NotNull] DbContextOptions options) : base(options)
        {
        }
    }
}
