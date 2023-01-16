using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DonationWebApp.Models
{
    public class MoneyDisasterViewModel
    {
        [DisplayName("Disaster")]
        
        [Key]
        public int MonDisId { get; set; }
        public string MonDisasterName { get; set; }

        public int MonAmountDonated { get; set; }

        public List<SelectListItem> ListOfDisasters { get; set; }
    }
}
