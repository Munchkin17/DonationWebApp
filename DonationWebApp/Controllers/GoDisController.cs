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
        private GoDiDbContext _databaseContext;

        public GoDisController(GoDiDbContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public IActionResult Index()
        {
            var goDisasterList = (from disaster in _databaseContext.GoodsDisasters
                                  select new SelectListItem()
                                  {
                                      Text = disaster.DisasterName,
                                      Value = disaster.DisId.ToString()
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
