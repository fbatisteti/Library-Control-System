using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Library.Shared;
using Library.Shared.Models;

namespace Library.Server
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // This here is a list for all the tables that will be in the DB
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Member> Members { get; set; }

        // This here is a list for the accessable "many to many" extra tables
        public DbSet<AuthorBook> AuthorBooks { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
    }
}
