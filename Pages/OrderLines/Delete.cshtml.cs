﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cucui_Elena_Proiect_Web.Data;
using Cucui_Elena_Proiect_Web.Models;

namespace Cucui_Elena_Proiect_Web.Pages.OrderLines
{
    public class DeleteModel : PageModel
    {
        private readonly Cucui_Elena_Proiect_Web.Data.Cucui_Elena_Proiect_WebContext _context;

        public DeleteModel(Cucui_Elena_Proiect_Web.Data.Cucui_Elena_Proiect_WebContext context)
        {
            _context = context;
        }

        [BindProperty]
        public OrderLine OrderLine { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OrderLine = await _context.OrderLine
                .Include(o => o.Order)
                .Include(o => o.Product).FirstOrDefaultAsync(m => m.ID == id);

            if (OrderLine == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OrderLine = await _context.OrderLine.FindAsync(id);

            if (OrderLine != null)
            {
                _context.OrderLine.Remove(OrderLine);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
