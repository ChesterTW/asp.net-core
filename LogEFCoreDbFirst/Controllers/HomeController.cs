using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LogEFCoreDbFirst.Models;
using LogEFCoreDbFirst.Data;
using LogEFCoreDbFirst.Repository;

namespace LogEFCoreDbFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IRepository<ThingsModel> rpt;
        public HomeController(ILogger<HomeController> logger, IRepository<ThingsModel> rpt)
        {
            _logger = logger;
            this.rpt = rpt;
        }

        public IActionResult Index()
        {
            var model = rpt.Reads();
            return View(model);
        }
        
        public IActionResult DeleteThings(List<int> chbId)
        {
            if(rpt.BatchDelete(chbId)){
                TempData["ResultMessage"]="批次刪除成功";
            }else
            {
                TempData["ResultMessage"]="批次刪除失敗";
            }
            return RedirectToAction("Index");
        }

        public IActionResult DeleteThing(int id)
        {
            if(rpt.Delete(rpt.Read(id))){
                TempData["ResultMessage"]="刪除成功";
            }else
            {
                TempData["ResultMessage"]="刪除失敗";
            }
            return RedirectToAction("Index");
        }

        public IActionResult EditThing(int id)
        {
            return View(rpt.Read(id));
        }

        [HttpPost]
        public IActionResult EditThing(ThingsModel thing)
        {
            if(rpt.Update(thing)){
                TempData["ResultMessage"]="更新成功";
            }else
            {
                TempData["ResultMessage"]="更新失敗";
            }
            return RedirectToAction("Index");
        }

        public IActionResult CreateThing()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateThing(ThingsModel thing)
        {
            if(rpt.Create(thing)){
                TempData["ResultMessage"]="新增成功";
            }else
            {
                TempData["ResultMessage"]="新增失敗";
            }
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
