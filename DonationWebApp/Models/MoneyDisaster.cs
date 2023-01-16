using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DonationWebApp.Models
{
    [Table("Disaster")]
    public class MoneyDisaster
    {
        [Key]
        public int DisasterId { get; set; }
        public string DisasterName { get; set; }

        public int AmountDonated { get; set; }
    }
}
