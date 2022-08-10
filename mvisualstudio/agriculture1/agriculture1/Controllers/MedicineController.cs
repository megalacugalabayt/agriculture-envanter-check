using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using agriculture1.Controllers;
using agriculture1.Models.Entity;

public class MedicineController : Controller
{
    // GET: Customer
    public ActionResult Index()
    {
        using (Model1 dbmodel = new Model1())
        {
            return View(dbmodel.medicine.ToList());
        }

    }

    // GET: Customer/Details/5
    public ActionResult Details(int? id)
    {
        using (Model1 dbmodel = new Model1())
        {
            return View(dbmodel.medicine.Where(x => x.medıd == id).FirstOrDefault());
        }

    }

    // GET: Customer/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: Customer/Create
    [HttpPost]
    public ActionResult Create(medicine medicine1)
    {
        try
        {
            using (Model1 dbmodel = new Model1())
            {
                dbmodel.medicine.Add(medicine1);
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
            return View(dbmodel.medicine.Where(x => x.medıd == id).FirstOrDefault());
        }
    }

    // POST: Customer/Edit/5
    [HttpPost]
    public ActionResult Edit(medicine medicine2)
    {
        try
        {
            using (Model1 dbmodel = new Model1())
            {
                dbmodel.Entry(medicine2).State = System.Data.Entity.EntityState.Modified;
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
            return View(dbmodel.medicine.Where(x => x.medıd == id).FirstOrDefault());
        }
    }

    // POST: Customer/Delete/5
    [HttpPost]
    public ActionResult Delete(int? id, medicine medicine3)
    {
        try
        {
            using (Model1 dbmodel = new Model1())
            {
                medicine3 = dbmodel.medicine.Where(x => x.medıd == id).FirstOrDefault();
                dbmodel.medicine.Remove(medicine3);
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
