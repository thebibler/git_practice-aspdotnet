using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Practice1.Data;
using Practice1.Models;

namespace Practice1.Pages.Franchises
{
    public class DetailsModel : PageModel
    {
        private readonly Practice1.Data.Practice1Context _context;

        public DetailsModel(Practice1.Data.Practice1Context context)
        {
            _context = context;
        }

        public Franchise Franchise { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Franchise = await _context.Franchise.FirstOrDefaultAsync(m => m.ID == id);

            if (Franchise == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
