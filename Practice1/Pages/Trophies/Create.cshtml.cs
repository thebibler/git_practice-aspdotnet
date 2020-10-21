using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Practice1.Data;
using Practice1.Models;

namespace Practice1.Pages.Trophies
{
    public class CreateModel : PageModel
    {
        private readonly Practice1.Data.Practice1Context _context;

        public CreateModel(Practice1.Data.Practice1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Trophy Trophy { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Trophy.Add(Trophy);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
