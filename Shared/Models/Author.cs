using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Library.Shared.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        [Required (ErrorMessage = "Please insert author's first name")]
        [Display (Name = "First Name")]
        public string FirstName { get; set; }

        [Required (ErrorMessage = "Please inset author's last name")]
        [Display (Name = "Last Name")]
        public string LastName { get; set; }

        public IList<AuthorBook> AuthorBooks { get; set; }
    }
}
