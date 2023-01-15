using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationWebApp.Models
{
    public class GoodsContext : DbContext
    {
        public GoodsContext(DbContextOptions<GoodsContext> options) : base(options)
        {
        }
        public DbSet<GoodsClass> GoodDonation { get; set; }
    }
}
