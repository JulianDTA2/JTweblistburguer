using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JTweblist.Models;

    public class JTweblistContext : DbContext
    {
        public JTweblistContext (DbContextOptions<JTweblistContext> options)
            : base(options)
        {
        }

        public DbSet<JTweblist.Models.Burger> Burger { get; set; } = default!;
    }
