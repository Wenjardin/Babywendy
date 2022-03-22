#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Babywendy.Data;
using Babywendy.models;

namespace Babywendy.Pages
{
    public class EditModel : PageModel
    {
        private readonly Babywendy.Data.BabywendyContext _context;

        public EditModel(Babywendy.Data.BabywendyContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Wendy).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WendyExists(Wendy.ID))
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

        private bool WendyExists(int id)
        {
            return _context.Wendy.Any(e => e.ID == id);
        }
    }
}
