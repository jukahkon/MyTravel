using MyTravel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace MyTravel.Controllers
{
    public class HomeController : Controller
    {
        private MyTravelContext db = new MyTravelContext();

        public ActionResult Index()
        {
            var vm = new MyTravelVM();
            vm.InternationalTrips = db.Trips.Include(e => e.Destination).Where(
                e => e.Destination.Country != "Finland").OrderByDescending(e => e.Year).ToList();

            vm.DomesticTrips = db.Trips.Include(e => e.Destination).Where(
                e => e.Destination.Country == "Finland").OrderByDescending(e => e.Year).ToList();
            
            return View(vm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
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