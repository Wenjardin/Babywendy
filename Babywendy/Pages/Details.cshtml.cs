#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Babywendy.Data;
using Babywendy.models;

namespace Babywendy.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly Babywendy.Data.BabywendyContext _context;

        public DetailsModel(Babywendy.Data.BabywendyContext context)
        {
            _context = context;
        }

        public Wendy Wendy { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Wendy = await _context.Wendy.FirstOrDefaultAsync(m => m.ID == id);

            if (Wendy == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
