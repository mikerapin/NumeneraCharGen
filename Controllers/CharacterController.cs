using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NumeneraCharGen.Models;

namespace NumeneraCharGen.Controllers
{
    public class CharacterController : Controller
    {
        private readonly NumeneraDb db = new NumeneraDb();

        // GET: Character
        public ActionResult Index()
        {
            Character temp = new Character()
            {
                DescriptorData = GetDescriptors(),
                TypeData = GetTypes(),
                FocusData = GetFoci()
            };

            return View(temp);
        }

        [HttpPost]
        // Generate Character
        public ActionResult New(string descriptor, string type, string focus)
        {
            Character newCharacter = new Character()
            {
                DescriptorData = GetDescriptor(int.Parse(descriptor)),
                TypeData = GetType(int.Parse(type)),
                FocusData = GetFocus(int.Parse(focus))
            };

            return View(newCharacter);
        }

        // GET: Character/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Character/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Character/Create
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

        // GET: Character/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Character/Edit/5
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

        // GET: Character/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Character/Delete/5
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

        // GET: Descriptors
        // Return all Descriptors from table (alphabetical)
        private List<Descriptor> GetDescriptors()
        {
            var descriptors = db.Descriptors.OrderBy(x => x.Name);
            return descriptors.ToList();
        }

        // GET: Descriptor
        // Return one descriptor from table based on given descriptor_id
        private List<Descriptor> GetDescriptor(int descriptor_id)
        {
            var descriptor = db.Descriptors.Where(x => x.Descriptor_id == descriptor_id);
            return descriptor.ToList();
        }

        // GET: Types
        // Return all Types from table (alphabetical)
        private List<Models.Type> GetTypes()
        {
            var types = db.Types.OrderBy(x => x.Name);
            return types.ToList();
        }

        // GET: Type
        // Return one type from table based on given type_id
        private List<Models.Type> GetType(int type_id)
        {
            var types = db.Types.Where(x => x.Type_id == type_id);
            return types.ToList();
        }

        // GET: Foci
        // Return all Foci from table (alphabetical)
        private List<Focus> GetFoci()
        {
            var focus = db.Foci.OrderBy(x => x.Name);
            return focus.ToList();
        }

        // GET: Focus
        // Return one focus from table based on given focus_id
        private List<Focus> GetFocus(int focus_id)
        {
            var focus = db.Foci.Where(x => x.Focus_id == focus_id);
            return focus.ToList();
        }


    }
}
