using Microsoft.EntityFrameworkCore;
using mchaltue.Models;

namespace mchaltue
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Magazine> Magazines { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./MVCLibrary.db");
        }
    }
}