using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Crisan_Melisa_lab2.Models;

namespace Crisan_Melisa_lab2.Data
{
    public class Crisan_Melisa_lab2Context : DbContext
    {
        public Crisan_Melisa_lab2Context (DbContextOptions<Crisan_Melisa_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Crisan_Melisa_lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Crisan_Melisa_lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Crisan_Melisa_lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Crisan_Melisa_lab2.Models.Category> Category { get; set; } = default!;
        public DbSet<Crisan_Melisa_lab2.Models.Member> Member { get; set; } = default!;
        public DbSet<Crisan_Melisa_lab2.Models.Borrowing> Borrowing { get; set; } = default!;
    }
}
