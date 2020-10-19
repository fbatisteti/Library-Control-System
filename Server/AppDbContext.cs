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

        // These are the database relations made by EF Core
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // BOOK - CATEGORY
            // Setting PK
            modelBuilder.Entity<BookCategory>()
                .HasKey(bc => new { bc.BookId, bc.CategoryId });

            // Setting FKs
            modelBuilder.Entity<BookCategory>()
                .HasOne(bc => bc.Book)
                .WithMany(b => b.BookCategories)
                .HasForeignKey(bc => bc.BookId);

            modelBuilder.Entity<BookCategory>()
                .HasOne(bc => bc.Category)
                .WithMany(c => c.BookCategories)
                .HasForeignKey(bc => bc.CategoryId);

            // AUTHOR - BOOK
            // Setting PK
            modelBuilder.Entity<AuthorBook>()
                .HasKey(ab => new { ab.BookId, ab.AuthorId });

            // Setting FKs
            modelBuilder.Entity<AuthorBook>()
                .HasOne(ab => ab.Author)
                .WithMany(a => a.AuthorBooks)
                .HasForeignKey(ab => ab.AuthorId);

            modelBuilder.Entity<AuthorBook>()
                .HasOne(ab => ab.Book)
                .WithMany(b => b.AuthorBooks)
                .HasForeignKey(ab => ab.BookId);

            // BOOK - MEMBER
            modelBuilder.Entity<Member>()
                .HasMany(m => m.Books)
                .WithOne(b => b.Member);

            modelBuilder.Entity<Book>()
                .HasOne(b => b.Member)
                .WithMany(m => m.Books);

            // SEEDING
            modelBuilder.Entity<Member>()
                .HasData(
                    new Member
                    {
                        MemberId = 1,
                        Name = "[System Member]"
                    }
                );

            modelBuilder.Entity<Category>()
                .HasData(
                    new Category
                    {
                        CategoryId = 1,
                        Name = "[System Category]"
                    }
                );

            modelBuilder.Entity<Author>()
                .HasData(
                    new Author
                    {
                        AuthorId = 1,
                        FirstName = "[System",
                        LastName = "Author]"
                    }
                );
        }
    }
}
