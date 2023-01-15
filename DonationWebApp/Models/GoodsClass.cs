using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DonationWebApp.Models
{
    public class GoodsClass
    {
        [Key]
        [Required]
        public int DonorId { get; set; }

        //The date that the user is donating is mandatory for the user to select.
        [Required]
        public DateTime DateOfDonation { get; set; }

        //The number of items is mandatory for the user to select.
        [Required]
        public int NumberOfItems { get; set; }

        //Category is mandatory for the user to enter.
        [Column(TypeName = "varchar(250)")]
        [Required]
        public string Category { get; set; }

        //New category of goods must be added if the user selects 'Other' by Category.
        [Column(TypeName = "varchar(250)")]
        
        public string AddNewCategory { get; set; }

        //The descripton of the item is mandatory for the user to enter.
        [Column(TypeName = "varchar(250)")]
        [Required]
        public string DescriptionOfItem { get; set; }

        //The user may remain annonymous.
        [Column(TypeName = "varchar(250)")]
        public string Donor { get; set; }
    }
}
