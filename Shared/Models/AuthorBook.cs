using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Shared.Models
{
    public class AuthorBook
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }

        // This is for the Many-to-Many Relationship to work
        protected void OnModelCreating(ModelBuilder modelBuilder)
        {
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
        }
    }
}
