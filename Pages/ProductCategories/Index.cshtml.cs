using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cucui_Elena_Proiect_Web.Data;
using Cucui_Elena_Proiect_Web.Models;

namespace Cucui_Elena_Proiect_Web.Pages.ProductCategories
{
    public class IndexModel : PageModel
    {
        private readonly Cucui_Elena_Proiect_Web.Data.Cucui_Elena_Proiect_WebContext _context;

        public IndexModel(Cucui_Elena_Proiect_Web.Data.Cucui_Elena_Proiect_WebContext context)
        {
            _context = context;
        }

        public IList<ProductCategory> ProductCategory { get;set; }

        public async Task OnGetAsync()
        {
            ProductCategory = await _context.ProductCategory
                .Include(p => p.Category)
                .Include(p => p.Product).ToListAsync();
        }
    }
}
