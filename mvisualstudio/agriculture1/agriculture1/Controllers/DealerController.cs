using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using agriculture1.Controllers;
using agriculture1.Models.Entity;

public class DealerController : Controller
{
    // GET: Customer
    public ActionResult Index()
    {
        using (Model1 dbmodel = new Model1())
        {
            return View(dbmodel.dealerr.ToList());
        }

    }

    // GET: Customer/Details/5
    public ActionResult Details(int? id)
    {
        using (Model1 dbmodel = new Model1())
        {
            return View(dbmodel.dealerr.Where(x => x.dealerıd == id).FirstOrDefault());
        }

    }

    // GET: Customer/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: Customer/Create
    [HttpPost]
    public ActionResult Create(dealerr dealer1)
    {
        try
        {
            using (Model1 dbmodel = new Model1())
            {
                dbmodel.dealerr.Add(dealer1);
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
            return View(dbmodel.dealerr.Where(x => x.dealerıd == id).FirstOrDefault());
        }
    }

    // POST: Customer/Edit/5
    [HttpPost]
    public ActionResult Edit(dealerr dealer2)
    {
        try
        {
            using (Model1 dbmodel = new Model1())
            {
                dbmodel.Entry(dealer2).State = System.Data.Entity.EntityState.Modified;
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
            return View(dbmodel.dealerr.Where(x => x.dealerıd == id).FirstOrDefault());
        }
    }

    // POST: Customer/Delete/5
    [HttpPost]
    public ActionResult Delete(int? id, dealerr dealer3)
    {
        try
        {
            using (Model1 dbmodel = new Model1())
            {
                dealer3 = dbmodel.dealerr.Where(x => x.dealerıd == id).FirstOrDefault();
                dbmodel.dealerr.Remove(dealer3);
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
