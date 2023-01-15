using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DonationWebApp.Models
{
    public class MoneyClass
    {
        [Key]
        [Required]
        public int DonorId { get; set; }
        [Required]
        public DateTime DateOfDonation { get; set; }
        [Required]
        public Double AmountOfDonation { get; set; }
        [Column(TypeName = "varchar(250)")]
        public String Donor { get; set; }
    }
}
