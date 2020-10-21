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
    public class IndexModel : PageModel
    {
        private readonly Practice1.Data.Practice1Context _context;

        public IndexModel(Practice1.Data.Practice1Context context)
        {
            _context = context;
        }

        public IList<Franchise> Franchise { get;set; }

        public async Task OnGetAsync()
        {
            Franchise = await _context.Franchise.ToListAsync();
        }
    }
}
