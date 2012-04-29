using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Offers.Core;

namespace Offers.Web.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;
        public HomeController(IRepository productRepository) {
        repository = productRepository;
        }

        public HomeController()
        {
            // TODO: Complete member initialization
        }
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Offers(int id)
        {
            return View(repository.Deals.Where(i => i.Catlog.CatLogId == id));
        }
        
    }
}
