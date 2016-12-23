using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VUEJS.Models;

namespace VUEJS.Controllers
{
    public class VUEController : Controller
    {
        // GET: VUE
        public ActionResult Index()
        {
            IList<Person> persons = new List<Person>();
            Person p;
            for (int i = 1; i <= 20; i++)
            {
                p = new Person { Id = i, Name = "客人" + i, SFZ = Guid.NewGuid().ToString() };
                persons.Add(p);
            }
            return View(persons);
        }

        // GET: VUE/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VUE/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VUE/Create
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

        // GET: VUE/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VUE/Edit/5
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

        // GET: VUE/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VUE/Delete/5
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
