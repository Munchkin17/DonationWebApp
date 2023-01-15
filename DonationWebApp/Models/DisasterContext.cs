using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationWebApp.Models
{
    public class DisasterContext :DbContext
    {
        public DisasterContext(DbContextOptions<DisasterContext> options) : base(options)
        {
        }
        public DbSet<DisasterClass> Disaster { get; set; }
    }
}
