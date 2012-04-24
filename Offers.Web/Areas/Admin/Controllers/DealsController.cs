using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Offers.Core;

namespace Offers.Web.Areas.Admin.Controllers
{ 
    public class DealsController : Controller
    {
        private DataContext db = new DataContext();

        //
        // GET: /Admin/Deals/

        public ViewResult Index()
        {
            return View(db.Deals.ToList());
        }

        //
        // GET: /Admin/Deals/Details/5

        public ViewResult Details(Guid id)
        {
            Deal deal = db.Deals.Find(id);
            return View(deal);
        }

        //
        // GET: /Admin/Deals/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Admin/Deals/Create

        [HttpPost]
        public ActionResult Create(Deal deal)
        {
            if (ModelState.IsValid)
            {
                deal.DealId = Guid.NewGuid();
                db.Deals.Add(deal);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(deal);
        }
        
        //
        // GET: /Admin/Deals/Edit/5
 
        public ActionResult Edit(Guid id)
        {
            Deal deal = db.Deals.Find(id);
            return View(deal);
        }

        //
        // POST: /Admin/Deals/Edit/5

        [HttpPost]
        public ActionResult Edit(Deal deal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(deal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(deal);
        }

        //
        // GET: /Admin/Deals/Delete/5
 
        public ActionResult Delete(Guid id)
        {
            Deal deal = db.Deals.Find(id);
            return View(deal);
        }

        //
        // POST: /Admin/Deals/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(Guid id)
        {            
            Deal deal = db.Deals.Find(id);
            db.Deals.Remove(deal);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}