using BusBookingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusBookingSystem.Controllers
{
    public class DriverController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        // GET: Driver
       
        public ActionResult Index()
        {
            var drivers = getDrivers();
            return View(drivers);
        }
               
        public IEnumerable<Driver> getDrivers()
        {
            //this var drivers is dbset in db , that get all drivers in db.
            var drivers = db.Drivers.ToList();
            return drivers;
        }

        public ActionResult Details(int id)
        {

            //SingleOrDefault() : this is for single specific customer.
            var driver = getDrivers().SingleOrDefault(c => c.PersonId == id);
            if (driver == null)
            {
                return HttpNotFound();
            }
            return View(driver);
        }

        /*HTTPPost method hides information from URL and does not bind data to URL. 
        It is more secure than HttpGet method but it is slower than HttpGet. 
        It is only useful when you are passing sensitive information to the server.
        sensitive information
        */
        [HttpPost] 
        public ActionResult Add(Driver createNewDriver) //mvc smart enough to bind this model to form(request) data because form data has pefix Driver
        {
            if(ModelState.IsValid)
            {//no validtion (Data annotaion != fo
                return View("Add", "createNewDriver");
            }
            /* when the request data to the application,
             * mvc framework will use this proprty to inititalize as parameters in action.
             */
            db.Drivers.Add(createNewDriver); //it's only added in memory.
            db.SaveChanges(); //it's added persitent in database.
            return RedirectToAction("Index"); //after saveing data back to Index(list of drivers).
        }

    }
}