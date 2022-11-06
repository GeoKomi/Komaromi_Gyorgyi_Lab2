using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Komaromi_Gyorgyi_Lab2.Models;

namespace Komaromi_Gyorgyi_Lab2.Data
{
    public class Komaromi_Gyorgyi_Lab2Context : DbContext
    {
        public Komaromi_Gyorgyi_Lab2Context (DbContextOptions<Komaromi_Gyorgyi_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Komaromi_Gyorgyi_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Komaromi_Gyorgyi_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Komaromi_Gyorgyi_Lab2.Models.Category> Category { get; set; }
    }
}
