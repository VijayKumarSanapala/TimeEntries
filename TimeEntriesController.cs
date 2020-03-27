using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimeEntriesEmployees.Models.BusinessAccessLayer;
using TimeEntriesEmployees.Models.DisplayClasses;
using TimeEntriesEmployees.Models.Entity;

namespace TimeEntriesEmployees.Controllers
{
    public class TimeEntriesController : Controller
    {
        TimeEntriesEntities connection = new TimeEntriesEntities();
        TimeEntriesBAL Tbal = new TimeEntriesBAL();

        // GET: TimeEntries details
        public ActionResult TimeEntriesRazor()
        {
            
            List<TimeEntriesViewModelDisplayClasses> Tlist = new List<TimeEntriesViewModelDisplayClasses>();
            Tlist = Tbal.GetAll().ToList();
            ViewBag.HostelView = Tlist;
            return View();
        }
        // GET: TimeEntriesEmployees
        [HttpGet]
        public ActionResult AddEmployeeEntry()
        {
            return View();
        }
        //Adding Employees to table
        [HttpPost]
        public ActionResult AddEmployeeEntry(TimeEntriesViewModelDisplayClasses Te)
        {
            bool Res = false;
            var EM = connection.TimeEntriesViewModels.Where(a => a.EmailAddress.Equals(Te.EmailAddress) && a.IsActive == true).FirstOrDefault();
            if (EM != null)
            {
                ModelState.AddModelError("EmailAddress", "EmailAddress is already Exists");
            }
            if (ModelState.IsValid)
                {
                    Res = Tbal.Save(Te);
                    Res = true;
                }
                else
                {
                    Res = false;
                }
            
            
            return View(Te);
        }
        // GET: TimeEntriesUpdated Data
        [HttpGet]
        public ActionResult UpdateEmployeeEntry(int id)
        {
            TimeEntriesViewModel tm = new TimeEntriesViewModel();
            TimeEntriesViewModelDisplayClasses tdisplay = new TimeEntriesViewModelDisplayClasses();
            tdisplay = Tbal.GetId(id);

            return View(tdisplay);
        }
        //Updating the Employeesdata
        [HttpPost]
        public ActionResult UpdateEmployeeEntry(TimeEntriesViewModelDisplayClasses Te)
        {
            bool res = false;

            if (ModelState.IsValid)
            {
                TimeEntriesViewModel tm = new TimeEntriesViewModel();
                res = Tbal.Update(Te);
                res = true;
                return RedirectToAction("TimeEntriesRazor");
            }
            else
            {              
                return View();                
            }                     

        }
        // Deleting the Employee Data
        [HttpPost]
        public bool Delete(int id)
        {
            bool res = false;
            try
            {
                res = Tbal.Delete(id);
                res = true;
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }

    }
}