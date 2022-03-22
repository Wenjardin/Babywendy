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
    public class IndexModel : PageModel
    {
        private readonly Babywendy.Data.BabywendyContext _context;

        public IndexModel(Babywendy.Data.BabywendyContext context)
        {
            _context = context;
        }

        public IList<Wendy> Wendy { get;set; }

        public async Task OnGetAsync()
        {
            Wendy = await _context.Wendy.ToListAsync();
        }
    }
}
