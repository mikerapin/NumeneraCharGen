using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NumeneraCharGen.Controllers
{
    public class FocusController : Controller
    {
        // GET: Focus
        public ActionResult Index()
        {
            return View();
        }

        // GET: Focus/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Focus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Focus/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Focus/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Focus/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Focus/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Focus/Delete/5
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
