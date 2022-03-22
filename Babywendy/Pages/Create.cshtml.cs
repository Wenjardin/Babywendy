#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Babywendy.Data;
using Babywendy.models;

namespace Babywendy.Pages
{
    public class CreateModel : PageModel
    {
        private readonly Babywendy.Data.BabywendyContext _context;

        public CreateModel(Babywendy.Data.BabywendyContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Wendy Wendy { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Wendy.Add(Wendy);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
