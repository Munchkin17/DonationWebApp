using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationWebApp.Models
{
    public class MoneyContext : DbContext
    {
        public MoneyContext(DbContextOptions<MoneyContext> options) : base(options)
        {
        }
        public DbSet<MoneyClass> MoneyDonation { get; set; }
    }
}
