using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EFCoreDbFirst.Models;
using EFCoreDbFirst.Data.ModelsDB;

namespace EFCoreDbFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            DBModels DB = new DBModels();
            List<ThingsModel> things = DB.GetThings();
            ViewBag.things = things;
            return View();
        }
        
        public IActionResult DeleteThing(int id){
            DBModels DB =new DBModels();
            DB.DeleteByID(id);
            return RedirectToAction("Index");
        }

        public IActionResult EditThing(int id)
        {
            DBModels DB = new DBModels();
            ThingsModel thing = DB.FindThingsByID(id);
            ViewData["ResultMessage"]="Enter EditTing Page";
            return View(thing);
        }

        [HttpPost]
        [ActionName("EditThing")]
        public IActionResult EditTingPost(ThingsModel thing)
        {
            DBModels DB = new DBModels();
            DB.UpdateThings(thing);
            ViewData["ResultMessage"]="Leave EditTing Page";
            return RedirectToAction("Index");
        }

        public IActionResult CreateThing()
        {
            ViewData["ResultMessage"]="Enter CreateThing Page";
            return View();
        }

        [HttpPost]
        public IActionResult CreateThing(ThingsModel thing)
        {
            try{
                DBModels DB = new DBModels();
                DB.CreateThings(thing);
            }catch(Exception e){
                Console.WriteLine(e.ToString());
            }
            ViewData["ResultMessage"]="Leave CreateThing Page";
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
