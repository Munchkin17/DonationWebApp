using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DonationWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DonationWebApp.Controllers
{
    public class MoDisController1 : Controller
    {
        private DisasterContext _disasterContext;

        public MoDisController1(DisasterContext disasterContext)
        {
            _disasterContext = disasterContext;
        }
        public IActionResult Index()
        {
            var moDisasterList = (from disaster in _disasterContext.Disaster
                                  select new SelectListItem()
                                  {
                                      Text = disaster.DisasterName,
                                      Value = disaster.DisasterId.ToString()
                                  }).ToList();
            moDisasterList.Insert(0, new SelectListItem()
            {
                Text = "---Select a Disaster---",
                Value = string.Empty
            });
            ViewBag.ListOfDisasters = moDisasterList;
            return View();
        }
        public IActionResult Index(MoneyDisasterViewModel moneyDisasterViewModel)
        {
            var selectedValue = moneyDisasterViewModel.MonDisId;
            return View(moneyDisasterViewModel);
        }
    }
}
