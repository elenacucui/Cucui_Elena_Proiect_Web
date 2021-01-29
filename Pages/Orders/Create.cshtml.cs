﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Cucui_Elena_Proiect_Web.Data;
using Cucui_Elena_Proiect_Web.Models;

namespace Cucui_Elena_Proiect_Web.Pages.Orders
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
        ViewData["ClientID"] = new SelectList(_context.Client, "ID", "Name");
            return Page();
        }

        [BindProperty]
        public Order Order { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Order.Add(Order);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
