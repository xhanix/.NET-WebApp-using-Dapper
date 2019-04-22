using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using DataLibrary;
using static DataLibrary.BussinessLogics.EmployeeProcessor;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult ViewEmployees()
        {
            var data = LoadEmployees();
            List<EmployeeModel> employees = new List<EmployeeModel>();
            foreach (var row in data)
            {
                employees.Add(
                    new EmployeeModel
                    {
                        EmployeeId = row.EmployeeId,
                        FirstName = row.FirstName,
                        LastName = row.LastName
                    }
                    );
            }
            return View(employees);
        }

        public ActionResult SignUp()
        {
            ViewBag.Message = "Employee Signup";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(EmployeeModel model)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated = CreateEmployee(model.EmployeeId, model.FirstName, model.LastName);
                return RedirectToAction("ViewEmployees");
            }

            return View();
        }
    }
}