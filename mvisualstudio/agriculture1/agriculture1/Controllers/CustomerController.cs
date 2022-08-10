using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using agriculture1.Controllers;
using agriculture1.Models.Entity;

public class CustomerController : Controller
{
    // GET: Customer
    public ActionResult Index()
    {
        using (Model1 dbmodel = new Model1())
        {
            return View(dbmodel.customer.ToList());
        }

    }

    // GET: Customer/Details/5
    public ActionResult Details(int? id)
    {
        using (Model1 dbmodel = new Model1())
        {
            return View(dbmodel.customer.Where(x => x.customerıd == id).FirstOrDefault());
        }

    }

    // GET: Customer/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: Customer/Create
    [HttpPost]
    public ActionResult Create(customer customer1)
    {
        try
        {
            using (Model1 dbmodel = new Model1())
            {
                dbmodel.customer.Add(customer1);
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
            return View(dbmodel.customer.Where(x => x.customerıd == id).FirstOrDefault());
        }
    }

    // POST: Customer/Edit/5
    [HttpPost]
    public ActionResult Edit(customer customer2)
    {
        try
        {
            using (Model1 dbmodel = new Model1())
            {
                dbmodel.Entry(customer2).State = System.Data.Entity.EntityState.Modified;
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
            return View(dbmodel.customer.Where(x => x.customerıd == id).FirstOrDefault());
        }
    }

    // POST: Customer/Delete/5
    [HttpPost]
    public ActionResult Delete(int? id, customer customer3)
    {
        try
        {
            using (Model1 dbmodel = new Model1())
            {
                customer3 = dbmodel.customer.Where(x => x.customerıd == id).FirstOrDefault();
                dbmodel.customer.Remove(customer3);
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
