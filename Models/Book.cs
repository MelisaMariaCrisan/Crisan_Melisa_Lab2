﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crisan_Melisa_lab2.Models
{
    public class Book
    {
        public int ID { get; set; }


        [Display(Name = "Book Title")]
        public string Title { get; set; }


        public int? AuthorID { get; set; }
        public Author? Author { get; set; } 


        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price {  get; set; }

        [DataType(DataType.Date)] 
        public DateTime PublishingDate { get; set; }

        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }

        public int? BorrowingID { get; set; }
        public ICollection<Borrowing>? Borrowings { get; set; }



        public ICollection<BookCategory>? BookCategories { get; set; }






    }
}
