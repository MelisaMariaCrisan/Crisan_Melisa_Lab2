﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Crisan_Melisa_lab2.Data;
using Crisan_Melisa_lab2.Models;

namespace Crisan_Melisa_lab2.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Crisan_Melisa_lab2.Data.Crisan_Melisa_lab2Context _context;

        public DetailsModel(Crisan_Melisa_lab2.Data.Crisan_Melisa_lab2Context context)
        {
            _context = context;
        }

        public Publisher Publisher { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);
            if (publisher == null)
            {
                return NotFound();
            }
            else
            {
                Publisher = publisher;
            }
            return Page();
        }
    }
}
