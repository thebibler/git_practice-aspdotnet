using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Practice1.Data;
using Practice1.Models;

namespace Practice1.Pages.Trophies
{
    public class DeleteModel : PageModel
    {
        private readonly Practice1.Data.Practice1Context _context;

        public DeleteModel(Practice1.Data.Practice1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Trophy Trophy { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Trophy = await _context.Trophy.FirstOrDefaultAsync(m => m.ID == id);

            if (Trophy == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Trophy = await _context.Trophy.FindAsync(id);

            if (Trophy != null)
            {
                _context.Trophy.Remove(Trophy);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
