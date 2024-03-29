using DropdownMVC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using static DropdownMVC.Models.EmployeContext;

namespace DropdownMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult EmployeDetail()
        {
            EmployeContext db = new EmployeContext();
            List<EmployeDetail> obj = db.GetEmployeDetails();

            return View(obj);
        }

        [HttpGet]
        public ActionResult Create()
        {

            ViewBag.StateData = EmployeContext.GetStates();
            ViewBag.CityData = EmployeContext.GetCitys(1);
            ViewBag.DepartmentData = EmployeContext.GetDepartment();

            return View();

        }

        [HttpPost]
        public ActionResult Create(EmployeDetail emp)
        {

            if (ModelState.IsValid == true)
            {


                {
                    var errors = ModelState.Where(x => x.Value.Errors.Count > 0)
                    .Select(x => new { x.Key, x.Value.Errors })
                    .ToArray();
                }
                EmployeContext context = new EmployeContext();
                bool Check = context.insertEmployeDetail(emp);
                if (Check == true)
                {

                    TempData["InsertMessage"] = "Your Message Insert Successfully.";
                    ModelState.Clear();
                    return RedirectToAction("EmployeDetail");
                }


            }

            ViewBag.StateData = EmployeContext.GetStates();
            ViewBag.CityData = EmployeContext.GetCitys(1);
            ViewBag.DepartmentData = EmployeContext.GetDepartment();

            return View();

        }
        [HttpGet]
        public ActionResult EditDetail(int? id)
        {
            EmployeContext context = new EmployeContext();
            var row = context.GetEmployeDetails().Find(Model => Model.ID == id);

            ViewBag.StateData = EmployeContext.GetStates();
            ViewBag.CityData = EmployeContext.GetCitys(1);
            ViewBag.DepartmentData = EmployeContext.GetDepartment();

            return View(row);

        }

        [HttpPost]
        public ActionResult EditDetail(int id, EmployeDetail emp)
        {
            EmployeContext context = new EmployeContext();
            bool Check = context.UpdateEmployeDetail(emp);
            if (Check == true)
            {

                TempData["UpdateMessage"] = "Your Message update Successfully.";
                ModelState.Clear();
                return RedirectToAction("EmployeDetail");
            }

            ViewBag.StateData = EmployeContext.GetStates();
            ViewBag.CityData = EmployeContext.GetCitys(1);
            ViewBag.DepartmentData = EmployeContext.GetDepartment();

            return View();
        }

        [HttpGet]
        public ActionResult DeleteDetail(int? id)
        {
            EmployeContext context = new EmployeContext();
            var row = context.GetEmployeDetails().Find(Model => Model.ID == id);
            ViewBag.StateData = EmployeContext.GetStates();
            ViewBag.CityData = EmployeContext.GetCitys(1);
            ViewBag.DepartmentData = EmployeContext.GetDepartment();
            return View(row);

        }

        [HttpPost]
        public ActionResult DeleteDetail(int id, EmployeDetail emp)
        {
            EmployeContext context = new EmployeContext();
            bool Check = context.DeleteEmployeDetail(id);
            if (Check == true)
            {

                TempData["InsertMessage"] = "Your Message Insert Successfully.";
                ModelState.Clear();
                return RedirectToAction("EmployeDetail");
            }

            ViewBag.StateData = EmployeContext.GetStates();
            ViewBag.CityData = EmployeContext.GetCitys(1);
            ViewBag.DepartmentData = EmployeContext.GetDepartment();

            return View();

        }

        public ActionResult BindCity(int StateID)
        {
            var City = EmployeContext.GetCitys(StateID).ToList();
            return Json(City, JsonRequestBehavior.AllowGet);



        }



    }
}
