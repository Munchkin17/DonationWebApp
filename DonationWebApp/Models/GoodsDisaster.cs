using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DonationWebApp.Models
{
    [Table("DisasterClass")]
    public class GoodsDisaster
    {
        [Key]
        public int DisId { get; set; }
        public string DisasterName { get; set; }

        public string GoodsDonated { get; set; }
    }
}
