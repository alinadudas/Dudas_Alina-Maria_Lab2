using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dudas_Alina_Maria_Lab2.Models;

namespace Dudas_Alina_Maria_Lab2.Data
{
    public class Dudas_Alina_Maria_Lab2Context : DbContext
    {
        public Dudas_Alina_Maria_Lab2Context (DbContextOptions<Dudas_Alina_Maria_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Dudas_Alina_Maria_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Dudas_Alina_Maria_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
