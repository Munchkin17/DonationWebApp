using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DonationWebApp.Models
{
    public class DisasterClass
    {
        [Key]
        public int DisasterId { get; set; }
        
        //Name of disaster is mandatory for the user to enter.
        [Column(TypeName = "varchar(250)")]
        [Required]
        public string DisasterName { get; set; }
        
        //Start date is mandatory for the user to select.
        [Required]
        public DateTime StartDate { get; set; }

        //End Date is mandatory for the user to select.
        [Required]
        public DateTime EndDate { get; set; }

        //Location of the disaster is mandatory for the user to input.
        [Column(TypeName = "varchar(250)")]
        [Required]
        public string Location { get; set; }

        //The description of a disaster is mandatory for the user to input.
        [Column(TypeName = "varchar(250)")]
        [Required]
        public string Description { get; set; }
        
        //Required aid types is mandatory for the user to select.
        [Column(TypeName = "varchar(250)")]
        [Required]
        public string RequiredAidTypes { get; set; }
    }
}
