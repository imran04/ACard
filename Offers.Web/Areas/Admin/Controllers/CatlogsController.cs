using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Offers.Core;
using System.Data;
namespace Offers.Web.Areas.Admin.Controllers
{
    [Authorize(Roles="Admin")]
    public class CatlogsController : Controller
    {
        //
        // GET: /Admin/Catlogs/
        private DataContext dc = new DataContext();
        public ActionResult Index()
        {

            return View(dc.CatLogs);
        }

        //
        // GET: /Admin/Catlogs/Details/5

        public ActionResult Details(int id)
        {

            return View(dc.CatLogs.Single(i=>i.CatLogId==id));
        }

        //
        // GET: /Admin/Catlogs/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Admin/Catlogs/Create

        [HttpPost]
        public ActionResult Create(Catlog Cat)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    dc.CatLogs.Add(Cat);
                    dc.SaveChanges();


                    return RedirectToAction("Index");
                }
                catch
                {
                    return View(Cat);
                }
            }
            else
                return View(Cat);
        }
        
        //
        // GET: /Admin/Catlogs/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View(dc.CatLogs.Single(i=>i.CatLogId==id));
        }

        //
        // POST: /Admin/Catlogs/Edit/5

        [HttpPost]
        public ActionResult Edit( Catlog cat)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    
                    dc.Entry(cat).State = EntityState.Modified;
                    dc.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }
            else
                return View(cat);
        }

        //
        // GET: /Admin/Catlogs/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }
        //
        // POST: /Admin/Catlogs/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
