using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using agriculture1.Controllers;
using agriculture1.Models.Entity;

public class AdviserController : Controller
{
    // GET: Customer
    public ActionResult Index()
    {
        using (Model1 dbmodel = new Model1())
        {
            return View(dbmodel.adviser.ToList());
        }

    }

    // GET: Customer/Details/5
    public ActionResult Details(int? id)
    {
        using (Model1 dbmodel = new Model1())
        {
            return View(dbmodel.adviser.Where(x => x.adviserıd == id).FirstOrDefault());
        }

    }

    // GET: Customer/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: Customer/Create
    [HttpPost]
    public ActionResult Create(adviser adviser1)
    {
        try
        {
            using (Model1 dbmodel = new Model1())
            {
                dbmodel.adviser.Add(adviser1);
                dbmodel.SaveChanges();
            }
            // TODO: Add insert logic here

            return RedirectToAction("Index");
        }
        catch
        {
            return View();
        }
    }

    // GET: Customer/Edit/5
    public ActionResult Edit(int? id)
    {
        using (Model1 dbmodel = new Model1())
        {
            return View(dbmodel.adviser.Where(x => x.adviserıd == id).FirstOrDefault());
        }
    }

    // POST: Customer/Edit/5
    [HttpPost]
    public ActionResult Edit(adviser adviser2)
    {
        try
        {
            using (Model1 dbmodel = new Model1())
            {
                dbmodel.Entry(adviser2).State = System.Data.Entity.EntityState.Modified;
                dbmodel.SaveChanges();
            }

            return RedirectToAction("Index");
        }
        catch
        {
            return View();
        }
    }

    // GET: Customer/Delete/5
    public ActionResult Delete(int? id)
    {
        using (Model1 dbmodel = new Model1())
        {
            return View(dbmodel.adviser.Where(x => x.adviserıd == id).FirstOrDefault());
        }
    }

    // POST: Customer/Delete/5
    [HttpPost]
    public ActionResult Delete(int? id, adviser adviser3)
    {
        try
        {
            using (Model1 dbmodel = new Model1())
            {
                adviser3 = dbmodel.adviser.Where(x => x.adviserıd == id).FirstOrDefault();
                dbmodel.adviser.Remove(adviser3);
                dbmodel.SaveChanges();
            }


            return RedirectToAction("Index");
        }
        catch
        {
            return View();
        }
    }
}
