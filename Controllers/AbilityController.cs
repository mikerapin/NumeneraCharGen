using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NumeneraCharGen.Controllers
{
    public class AbilityController : Controller
    {
        // GET: Ability
        public ActionResult Index()
        {
            return View();
        }

        // GET: Ability/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Ability/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ability/Create
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

        // GET: Ability/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Ability/Edit/5
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

        // GET: Ability/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ability/Delete/5
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
