﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dudas_Alina_Maria_Lab2.Data;
using Dudas_Alina_Maria_Lab2.Models;

namespace Dudas_Alina_Maria_Lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Dudas_Alina_Maria_Lab2.Data.Dudas_Alina_Maria_Lab2Context _context;

        public IndexModel(Dudas_Alina_Maria_Lab2.Data.Dudas_Alina_Maria_Lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book.Include(b=>b.Publisher).ToListAsync();
                
            }
        }
    }
}
