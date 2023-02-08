using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Tables.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
            if (ModelState.IsValid)
            {
                db.Tables.Add(table);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table);
        [HttpPost]
        public ActionResult Create(Insuree insuree)
        {
            // Set the base price to $50.
            decimal basePrice = 50.0m;

            // If the user's age is 18 or under, add $100 to the monthly total.
            if (insuree.Age <= 18)
            {
                basePrice += 100.0m;
            }
            // If the user's age is between 19 and 25, add $50 to the monthly total.
            else if (insuree.Age >= 19 && insuree.Age <= 25)
            {
                basePrice += 50.0m;
            }
            // If the user's age is 26 or older, add $25 to the monthly total.
            else if (insuree.Age >= 26)
            {
                basePrice += 25.0m;
            }

            // If the car's year is before 2000, add $25 to the monthly total.
            if (insuree.CarYear < 2000)
            {
                basePrice += 25.0m;
            }
            // If the car's year is after 2015, add $25 to the monthly total.
            else if (insuree.CarYear > 2015)
            {
                basePrice += 25.0m;
            }

            // If the car's Make is a Porsche, add $25 to the price.
            if (insuree.CarMake.ToLower() == "porsche")
            {
                basePrice += 25.0m;

                // If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price.
                if (insuree.CarModel.ToLower() == "911 carrera")
                {
                    basePrice += 25.0m;
                }
            }

            // Add $10 to the monthly total for every speeding ticket the user has.
            basePrice += 10.0m * insuree.SpeedingTickets;

            // If the user has ever had a DUI, add 25% to the total.
            if (insuree.DUI)
            {
                basePrice *= 1.25m;
            }

            // If it's full coverage, add 50% to the total.
            if (insuree.FullCoverage)
            {
                basePrice *= 1.5m;
            }

            // Saves the calculated quote to the database
            using (YourDbContext db = new YourDbContext())
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();
            }

            // Redirects the user to the Quote Confirmation page.
            return RedirectToAction("QuoteConfirmation", "Insuree", new { quote = basePrice });
        }

        // GET: Insuree/QuoteConfirmation.
        public ActionResult QuoteConfirmation(decimal quote)
        {
            ViewBag.Quote = quote
        
        }

        // GET: Insuree/Edit/5.
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Edit/5.
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table table = db.Tables.Find(id);
            db.Tables.Remove(table);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
