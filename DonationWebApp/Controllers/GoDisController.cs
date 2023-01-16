using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DonationWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DonationWebApp.Controllers
{
    public class GoDisController : Controller
    {
        private DisasterContext _disasterContext;

        public GoDisController(DisasterContext disasterContext)
        {
            _disasterContext = disasterContext;
        }
        public IActionResult Index()
        {
            var goDisasterList = (from Disasters in _disasterContext.Disaster
                                  select new SelectListItem()
                                  {
                                      Text = Disasters.DisasterName,
                                      Value = Disasters.DisasterId.ToString()
                                  }) .ToList();
            goDisasterList.Insert(0, new SelectListItem()
            {
                Text = "---Select a Disaster",
                Value=string.Empty
            });
            ViewBag.ListOfDisasters = goDisasterList;
            return View();
        }
        public IActionResult Index(GoodsDisasterViewModel goodsDisasterViewModel)
        {
            var selectedValue = goodsDisasterViewModel.DisId;
            return View(goodsDisasterViewModel);
        }
    }
}
