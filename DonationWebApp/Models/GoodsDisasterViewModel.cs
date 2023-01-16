using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DonationWebApp.Models
{
    public class GoodsDisasterViewModel
    {
        [DisplayName("DisasterClass")]
        public string DisId { get; set; }

        public string DisasterName { get; set; }

        public string GoodsDonated { get; set; }

        public List<SelectListItem> ListOfDisasters{ get; set; }
    }
}
