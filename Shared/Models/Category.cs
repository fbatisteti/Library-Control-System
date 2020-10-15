using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Library.Shared.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        
        [Required (ErrorMessage = "Please insert a name for the category/literary genre")]
        [Display (Name = "Category/literary genre")]
        public string Name { get; set; }

        public IList<BookCategory> BookCategories { get; set; }
    }
}
