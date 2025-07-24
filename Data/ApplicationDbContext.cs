using Microsoft.EntityFrameworkCore;
using RickAndMorty.Model;

namespace RickAndMorty.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<Character> Character { get; set; }
    }
}
