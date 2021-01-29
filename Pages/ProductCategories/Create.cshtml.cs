﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Cucui_Elena_Proiect_Web.Data;
using Cucui_Elena_Proiect_Web.Models;

namespace Cucui_Elena_Proiect_Web.Pages.ProductCategories
{
    public class CreateModel : PageModel
    {
        private readonly Cucui_Elena_Proiect_Web.Data.Cucui_Elena_Proiect_WebContext _context;

        public CreateModel(Cucui_Elena_Proiect_Web.Data.Cucui_Elena_Proiect_WebContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CategoryID"] = new SelectList(_context.Category, "ID", "ID");
        ViewData["ProductID"] = new SelectList(_context.Product, "ID", "ID");
            return Page();
        }

        [BindProperty]
        public ProductCategory ProductCategory { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ProductCategory.Add(ProductCategory);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}