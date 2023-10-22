﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Groza_Tudor_Lab2.Data;
using Groza_Tudor_Lab2.Models;

namespace Groza_Tudor_Lab2.Pages.Author
{
    public class DetailsModel : PageModel
    {
        private readonly Groza_Tudor_Lab2.Data.Groza_Tudor_Lab2Context _context;

        public DetailsModel(Groza_Tudor_Lab2.Data.Groza_Tudor_Lab2Context context)
        {
            _context = context;
        }

      public Groza_Tudor_Lab2.Models.Author Author { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Author == null)
            {
                return NotFound();
            }

            var author = await _context.Author.FirstOrDefaultAsync(m => m.ID == id);
            if (author == null)
            {
                return NotFound();
            }
            else 
            {
                Author = author;
            }
            return Page();
        }
    }
}
