using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pantea_Andrei_Daniel_Lab8.Models;

namespace Pantea_Andrei_Daniel_Lab8.Data
{
    public class Pantea_Andrei_Daniel_Lab8Context : DbContext
    {
        public Pantea_Andrei_Daniel_Lab8Context (DbContextOptions<Pantea_Andrei_Daniel_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Pantea_Andrei_Daniel_Lab8.Models.Book> Book { get; set; }
    }
}
