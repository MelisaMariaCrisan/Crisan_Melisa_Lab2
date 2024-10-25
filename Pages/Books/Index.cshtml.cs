using Crisan_Melisa_lab2.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Crisan_Melisa_lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Crisan_Melisa_lab2.Data.Crisan_Melisa_lab2Context _context;

        public IndexModel(Crisan_Melisa_lab2.Data.Crisan_Melisa_lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book
                 .Include(b => b.Publisher)
                .ToListAsync();
        }
    }
}
