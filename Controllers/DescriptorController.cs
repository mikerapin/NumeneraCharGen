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
    public class DescriptorController : Controller
    {
        private readonly NumeneraDb db = new NumeneraDb();
        private SqlConnection con;

        private void Connection()
        {
            string configString = ConfigurationManager.ConnectionStrings["NumeneraDb"].ToString();
            con = new SqlConnection(configString);
        }

        // GET: Descriptor
        public ActionResult Index()
        {
            var descriptors = db.Descriptors.OrderBy(d => d.Name);
            return View(descriptors.ToList());
        }

        // GET: Descriptor/Details/5
        public ActionResult Details(int id)
        {
            var descriptor = db.Descriptors.Where(d => d.Descriptor_id == id).FirstOrDefault();
            return View(descriptor);
        }

        // GET: Descriptor/Create
        [Authorize(Roles = "Admin")]
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

                if (AddNewDescriptor())
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

        // Add Descriptor
        public bool AddNewDescriptor()
        {
            // Pass Values to Connection
            Connection();
            SqlCommand command = new SqlCommand("numeneradb.AddNewDescriptor", con);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Name", Request.Form["Name"]);
            command.Parameters.AddWithValue("@Might", Request.Form["Might"]);
            command.Parameters.AddWithValue("@Speed", Request.Form["Speed"]);
            command.Parameters.AddWithValue("@Intellect", Request.Form["Intellect"]);
            command.Parameters.AddWithValue("@Armor", Request.Form["Armor"]);
            command.Parameters.AddWithValue("@Recovery", Request.Form["Recovery"]);
            command.Parameters.AddWithValue("@Training", Request.Form["Training"]);
            command.Parameters.AddWithValue("@Inability", Request.Form["Inability"]);
            command.Parameters.AddWithValue("@Trait", Request.Form["Trait"]);
            command.Parameters.AddWithValue("@Equipment", Request.Form["Equipment"]);
            command.Parameters.AddWithValue("@Shins", Request.Form["Shins"]);
            command.Parameters.AddWithValue("@Page", Request.Form["Page"]);
            
            con.Open();
            int rowsAdded = command.ExecuteNonQuery();
            con.Close();

            if (rowsAdded > 0) { return true; }
            else { return false; }
        }


        // GET: Descriptor/Edit/5
        [Authorize(Roles = "Admin")]
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
            catch (Exception e)
            {
                Console.WriteLine(e);
                return View();
            }
        }

        // GET: Descriptor/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Descriptor/Delete/5
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
