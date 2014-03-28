using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Skate.Shared;
using Skate.Presentation;
using SkateRepository.Interface;
using Skate.Infrastructure;

using SkateRepository.Service;namespace Skate.Web.Controllers
{
    public class SkateboardController : Controller
    { 
        //internal readonly ISkateRepository repository;

        //public SkateboardController(ISkateRepository repository)
        //{
        //    this.repository = new ServiceRepository();
        //}     

        SkateContainer container = new SkateContainer();

        public ActionResult Index()
        {
            return View(container.ViewModel);
        }

        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        ////
        //// GET: /Skateboard/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        ////
        //// GET: /Skateboard/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        ////
        //// POST: /Skateboard/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        ////
        //// GET: /Skateboard/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        ////
        //// POST: /Skateboard/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        ////
        //// GET: /Skateboard/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        ////
        //// POST: /Skateboard/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
