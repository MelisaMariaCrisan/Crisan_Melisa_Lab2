﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Crisan_Melisa_lab2.Data;
using Crisan_Melisa_lab2.Models;

namespace Crisan_Melisa_lab2.Pages.Borrowings
{
    public class IndexModel : PageModel
    {
        private readonly Crisan_Melisa_lab2.Data.Crisan_Melisa_lab2Context _context;

        public IndexModel(Crisan_Melisa_lab2.Data.Crisan_Melisa_lab2Context context)
        {
            _context = context;
        }

        public IList<Borrowing> Borrowing { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Borrowing = await _context.Borrowing
                .Include(b => b.Book)
                .ThenInclude(b => b.Author)
                .Include(b => b.Member).ToListAsync();
        }
    }
}
