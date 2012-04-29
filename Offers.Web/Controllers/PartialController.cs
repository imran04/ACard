using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Offers.Core;

namespace Offers.Web.Controllers
{
    public class PartialController : Controller
    {

       private IRepository repository;
        public PartialController(IRepository productRepository) {
        repository = productRepository;
        }
        
        [ChildActionOnly]
        public ActionResult RightNav()
        {
            var cat = repository.CatLogs.ToList();   
            return PartialView(cat);
        }

    }
}
