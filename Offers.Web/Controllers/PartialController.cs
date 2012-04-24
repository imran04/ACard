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

        private DataContext dc = new DataContext();
        
        [ChildActionOnly]
        public ActionResult RightNav()
        {
            var cat = dc.CatLogs.ToList();   
            return PartialView();
        }

    }
}
