using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using MySql.Data;
using NumeneraCharGen.Models;

namespace NumeneraCharGen.Controllers
{
    public class FocusController : Controller
    {
        private readonly NumeneraDb db = new NumeneraDb();
        private SqlConnection con;

        private void Connection()
        {
            string configString = ConfigurationManager.ConnectionStrings["NumeneraDb"].ToString();
            con = new SqlConnection(configString);
        }

        // GET: Focus
        public ActionResult Index()
        {
            var foci = db.Foci.OrderBy(d => d.Name);
            return View(foci.ToList());
        }

        // GET: Focus/Details/5
        public ActionResult Details(int id)
        {
            var focus = db.Foci.Where(d => d.Focus_id == id).FirstOrDefault();
            return View(focus);
        }

        // GET: Focus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Focus/Create
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                if (AddNewFocus())
                {
                    ViewBag.Message = "Descriptor added successfully";
                    return View();
                }


                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                ViewBag.ErrorMessage = "Please fill out all neccessary data before submitting";
                return View();
            }
        }

        // Add Focus
        public bool AddNewFocus()
        {
            // Pass Values to Connection
            Connection();
            SqlCommand command = new SqlCommand("numeneradb.AddNewFocus", con);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Name", Request.Form["Name"]);
            command.Parameters.AddWithValue("@Might", Request.Form["Might"]);
            command.Parameters.AddWithValue("@Speed", Request.Form["Speed"]);
            command.Parameters.AddWithValue("@Intellect", Request.Form["Intellect"]);
            command.Parameters.AddWithValue("@Power", Request.Form["Armor"]);
            command.Parameters.AddWithValue("@Equipment", Request.Form["Equipment"]);
            command.Parameters.AddWithValue("@Page", Request.Form["Page"]);
            command.Parameters.AddWithValue("@Description", Request.Form["Description"]);

            con.Open();
            int rowsAdded = command.ExecuteNonQuery();
            con.Close();

            if (rowsAdded > 0) { return true; }
            else { return false; }
        }

        // GET: Focus/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Focus/Edit/5
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Focus/Delete/5
        [Authorize(Roles = "Admin")]
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
