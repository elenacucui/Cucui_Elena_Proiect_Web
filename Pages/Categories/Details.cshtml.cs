using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cucui_Elena_Proiect_Web.Data;
using Cucui_Elena_Proiect_Web.Models;

namespace Cucui_Elena_Proiect_Web.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly Cucui_Elena_Proiect_Web.Data.Cucui_Elena_Proiect_WebContext _context;

        public DetailsModel(Cucui_Elena_Proiect_Web.Data.Cucui_Elena_Proiect_WebContext context)
        {
            _context = context;
        }

        public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);

            if (Category == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
