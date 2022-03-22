#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Babywendy.models;

namespace Babywendy.Data
{
    public class BabywendyContext : DbContext
    {
        public BabywendyContext (DbContextOptions<BabywendyContext> options)
            : base(options)
        {
        }

        public DbSet<Babywendy.models.Wendy> Wendy { get; set; }
    }
}
