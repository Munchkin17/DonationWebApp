using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DonationWebApp.Models
{
    [Table("MoneyDisasterAllo")]
    public class MoneyDisaster
    {
        [Key]
        public int MonDisId { get; set; }
        public string MonDisasterName { get; set; }

        public int MonAmountDonated { get; set; }
    }
}
