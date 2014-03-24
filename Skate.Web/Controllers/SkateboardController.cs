using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Skate.Shared;
using Skate.Presentation;

namespace Skate.Web.Controllers
{
    public class SkateboardController : Controller
    {        
        //
        // GET: /Skateboard/
        public ActionResult Index()
        {
           var viewModel = new SkateViewModel();     
            
            return View(viewModel);
        }

        //
        // GET: /Skateboard/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Skateboard/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Skateboard/Create
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

        //
        // GET: /Skateboard/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Skateboard/Edit/5
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

        //
        // GET: /Skateboard/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Skateboard/Delete/5
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
