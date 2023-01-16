using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationWebApp.Models
{
    public class MoDiDbContext :DbContext
    {
        public MoDiDbContext(DbContextOptions<MoDiDbContext> options):base(options)
        {

        }
        public DbSet<MoneyDisaster> MoneyDisaster { get; set; }
    }
}
