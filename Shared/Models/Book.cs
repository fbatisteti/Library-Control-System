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

        [Required (ErrorMessage = "Please select at least 1 (one) author")]
        [Display (Name = "Author(s)")]
        public IList<AuthorBook> AuthorBooks { get; set; }
        
        public IList<Category> Categories { get; set; }
        
        public Member Custody { get; set; }
    }
}
