using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Practice1.Data;
using Practice1.Models;

namespace Practice1.Pages.Trophies
{
    public class EditModel : PageModel
    {
        private readonly Practice1.Data.Practice1Context _context;

        public EditModel(Practice1.Data.Practice1Context context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Trophy).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrophyExists(Trophy.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TrophyExists(string id)
        {
            return _context.Trophy.Any(e => e.ID == id);
        }
    }
}
