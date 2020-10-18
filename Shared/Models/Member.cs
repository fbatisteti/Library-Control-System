using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Library.Shared.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        
        [Required (ErrorMessage = "Please insert member's name/nickname")]
        [Display (Name = "Name/nickname")]
        public string Name { get; set; }

        public string Notes { get; set; }

        public ICollection<Book> Books { get; set; }

        // This is for the One-to-Many Relationship to work
        protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>()
                .HasMany(m => m.Books)
                .WithOne(b => b.Custody);
        }
    }
}
