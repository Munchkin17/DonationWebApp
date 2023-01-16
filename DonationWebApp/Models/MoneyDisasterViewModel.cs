using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DonationWebApp.Models
{
    public class MoneyDisasterViewModel
    {
        [DisplayName("Disaster")]
        public string DisasterId { get; set; }

        public List<SelectListItem> ListOfDisasters { get; set; }
    }
}
