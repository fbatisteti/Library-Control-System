using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Library.Shared.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required (ErrorMessage = "Please insert book's title")]
        [Display (Name = "Title")]
        public string Title { get; set; }

        public IList<AuthorBook> AuthorBooks { get; set; }
        
        public IList<BookCategory> BookCategories { get; set; }
        
        public Member Custody { get; set; }

        // This is for the One-to-Many Relationship to work
        protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Custody)
                .WithMany(m => m.Books);
        }
    }
}
