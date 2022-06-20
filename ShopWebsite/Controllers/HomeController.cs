using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using ShopWebsite.Data;
using ShopWebsite.Models;
using ShopWebsite.Repository;
using ShopWebsite.Services;

namespace ShopWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IRepository<Product> rptP;
        private IRepository<Category> rptC;
        private IService<Category> srvP;
        public HomeController(ILogger<HomeController> logger,IRepository<Product> rptP,IRepository<Category> rptC,IService<Category> srvP)
        {
            _logger = logger;
            this.rptP = rptP;
            this.rptC = rptC;
            this.srvP = srvP;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Accounts acc)
        {

            return View();
        }

        public IActionResult DetailProduct(int id)
        {
            return View(rptP.Read(id));
        }

        public IActionResult DeleteProduct(int id)
        {
            ViewBag.CategoryId = srvP.DropDownListItem(rptC.Reads());
            return View(rptP.Read(id));
        }

        [HttpPost]
        public IActionResult DeleteProduct(Product pdt)
        {
            if(rptP.Delete(rptP.Read(pdt.Id))){
                TempData["ResultMessage"]="刪除成功";
            }else{
                TempData["ResultMessage"]="刪除失敗";
            }
            return RedirectToAction("ProductList");
        } 

        public IActionResult EditProduct(int id)
        {
            ViewBag.CategoryId = srvP.DropDownListItem(rptC.Reads());
            return View(rptP.Read(id));
        }

        [HttpPost]
        public IActionResult EditProduct(Product pdt,IFormFile img)
        {
            pdt.Image = rptP.CreateImage(img);
            if(rptP.Update(pdt)){
                TempData["ResultMessage"]="修改成功";
            }else{
                TempData["ResultMessage"]="修改失敗";
            }
            return RedirectToAction("ProductList");
        }

        public IActionResult ProductList()
        {
            return View(rptP.Reads());
        }

        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            if(rptC.Create(category)){
                TempData["ResultMessage"]="類別新增成功";
            }else
            {
                TempData["ResultMessage"]="類別新增失敗";
            }
            return View();
        }

        public IActionResult CreateProduct()
        {
            return View(srvP.DropDownListItem(rptC.Reads()));
        }
        [HttpPost]
        public IActionResult CreateProduct(Product pdt,IFormFile img)
        {
            pdt.Image = rptP.CreateImage(img);
            if(rptP.Create(pdt)){
                TempData["ResultMessage"]="新增成功";
            }else
            {
                TempData["ResultMessage"]="新增失敗";
            }
            return View(srvP.DropDownListItem(rptC.Reads()));
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
