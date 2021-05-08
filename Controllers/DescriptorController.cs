﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySql.Data;
using NumeneraCharGen.Models;

namespace NumeneraCharGen.Controllers
{
    public class DescriptorController : Controller
    {
        private readonly NumeneraDb db = new NumeneraDb();

        // GET: Descriptor
        public ActionResult Index()
        {
            var descriptors = db.Descriptors.OrderBy(d => d.Name);
            return View(descriptors.ToList());
        }

        // GET: Descriptor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Descriptor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Descriptor/Create
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

        // GET: Descriptor/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Descriptor/Edit/5
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

        // GET: Descriptor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Descriptor/Delete/5
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