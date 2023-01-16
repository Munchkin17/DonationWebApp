using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationWebApp.Models
{
    public class GoDiDbContext:DbContext
    {
        public GoDiDbContext(DbContextOptions<GoDiDbContext> options):base(options)
        {

        }
        public DbSet<GoodsDisaster> GoodsDisasters { get; set; }
    }
}
