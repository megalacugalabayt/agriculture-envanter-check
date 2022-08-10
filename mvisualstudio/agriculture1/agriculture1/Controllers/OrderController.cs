using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using agriculture1.Controllers;
using agriculture1.Models.Entity;

public class OrderController : Controller
{
    // GET: Customer
    public ActionResult Index()
    {
        using (Model1 dbmodel = new Model1())
        {
            return View(dbmodel.orders.ToList());
        }

    }

    // GET: Customer/Details/5
    public ActionResult Details(int? id)
    {
        using (Model1 dbmodel = new Model1())
        {
            return View(dbmodel.orders.Where(x => x.orderıd == id).FirstOrDefault());
        }

    }

    // GET: Customer/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: Customer/Create
    [HttpPost]
    public ActionResult Create(orders order1)
    {
        try
        {
            using (Model1 dbmodel = new Model1())
            {
                dbmodel.orders.Add(order1);
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
            return View(dbmodel.orders.Where(x => x.orderıd == id).FirstOrDefault());
        }
    }

    // POST: Customer/Edit/5
    [HttpPost]
    public ActionResult Edit(orders order2)
    {
        try
        {
            using (Model1 dbmodel = new Model1())
            {
                dbmodel.Entry(order2).State = System.Data.Entity.EntityState.Modified;
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
            return View(dbmodel.orders.Where(x => x.orderıd == id).FirstOrDefault());
        }
    }

    // POST: Customer/Delete/5
    [HttpPost]
    public ActionResult Delete(int? id, orders order3)
    {
        try
        {
            using (Model1 dbmodel = new Model1())
            {
                order3 = dbmodel.orders.Where(x => x.orderıd == id).FirstOrDefault();
                dbmodel.orders.Remove(order3);
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
