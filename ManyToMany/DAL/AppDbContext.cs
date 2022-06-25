using ManyToMany.Models;
using Microsoft.EntityFrameworkCore;

namespace ManyToMany.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
        public DbSet<Book>Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<SosialAccount> SosialAccounts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<BookGenre> BookGenres { get; set; }
    }
}
