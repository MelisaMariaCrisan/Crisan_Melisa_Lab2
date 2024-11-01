﻿using System.ComponentModel.DataAnnotations;

namespace Crisan_Melisa_lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public ICollection<Book>? Books { get; set; }
        
    }
}
