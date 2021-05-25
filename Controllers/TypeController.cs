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
    public class TypeController : Controller
    {
        private readonly NumeneraDb db = new NumeneraDb();
        private SqlConnection con;

        private void Connection()
        {
            string configString = ConfigurationManager.ConnectionStrings["NumeneraDb"].ToString();
            con = new SqlConnection(configString);
        }


        // GET: Type
        public ActionResult Index()
        {
            var types = db.Types.OrderBy(d => d.Name);
            return View(types.ToList());
        }

        // GET: Type/Details/5
        public ActionResult Details(int id)
        {
            var type = db.Types.Where(d => d.Type_id == id).FirstOrDefault();
            return View(type);
        }

        // GET: Type/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Type/Create
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                if (AddNewType())
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
        public bool AddNewType()
        {
            // Pass Values to Connection
            Connection();
            SqlCommand command = new SqlCommand("numeneradb.AddNewType", con);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Name", Request.Form["Name"]);
            command.Parameters.AddWithValue("@Might", Request.Form["Might"]);
            command.Parameters.AddWithValue("@Speed", Request.Form["Speed"]);
            command.Parameters.AddWithValue("@Intellect", Request.Form["Intellect"]);
            command.Parameters.AddWithValue("@Might_Edge", Request.Form["Might_Edge"]);
            command.Parameters.AddWithValue("@Speed_Edge", Request.Form["Speed_Edge"]);
            command.Parameters.AddWithValue("@Intellect_Edge", Request.Form["Intellect_Edge"]);
            command.Parameters.AddWithValue("@Effort", Request.Form["Effort"]);
            command.Parameters.AddWithValue("@Traits", Request.Form["Traits"]);
            command.Parameters.AddWithValue("@Training", Request.Form["Training"]);
            command.Parameters.AddWithValue("@Inability", Request.Form["Inability"]);
            command.Parameters.AddWithValue("@Equipment", Request.Form["Equipment"]);
            command.Parameters.AddWithValue("@Shins", Request.Form["Shins"]);
            command.Parameters.AddWithValue("@Page", Request.Form["Page"]);
            command.Parameters.AddWithValue("@Description", Request.Form["Description"]);

            con.Open();
            int rowsAdded = command.ExecuteNonQuery();
            con.Close();

            if (rowsAdded > 0) { return true; }
            else { return false; }
        }

        // GET: Type/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Type/Edit/5
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

        // GET: Type/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Type/Delete/5
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
