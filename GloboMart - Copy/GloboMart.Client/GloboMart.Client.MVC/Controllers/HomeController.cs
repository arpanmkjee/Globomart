using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GloboMart.Client.MVC.Models;

namespace GloboMart.Client.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddProduct()
        {
            ViewBag.Message = "";

            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(ProductViewModel p)
        {
            return View();
        }

        public ActionResult SearchProducts()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult GetProductPrice()
        {
            ViewBag.Message = "";

            return View();
        }
    }
}