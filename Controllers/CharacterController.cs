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

        // Generate Character
        private ActionResult GenerateCharacter(int description_id, int type_id, int focus_id)
        {
            Character newCharacter = new Character()
            {
                DescriptorData = GetDescriptor(description_id),
                TypeData = GetType(type_id),
                FocusData = GetFocus(focus_id)
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
        private List<Descriptor> GetDescriptors()
        {
            var descriptors = db.Descriptors.OrderBy(x => x.Name);
            return descriptors.ToList();
        }

        // GET: Descriptor
        private List<Descriptor> GetDescriptor(int descriptor_id)
        {
            var descriptor = db.Descriptors.Where(x => x.Descriptor_id == descriptor_id);
            return descriptor.ToList();
        }

        // GET: Types
        private List<Models.Type> GetTypes()
        {
            var types = db.Types.OrderBy(x => x.Name);
            return types.ToList();
        }

        // GET: Type
        private List<Models.Type> GetType(int type_id)
        {
            var types = db.Types.Where(x => x.Type_id == type_id);
            return types.ToList();
        }

        // GET: Foci
        private List<Focus> GetFoci()
        {
            var focus = db.Foci.OrderBy(x => x.Name);
            return focus.ToList();
        }

        // GET: Focus
        private List<Focus> GetFocus(int focus_id)
        {
            var focus = db.Foci.OrderBy(x => x.Focus_id == focus_id);
            return focus.ToList();
        }


    }
}
