using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            var p = new PersonModel();
            var t = 7 / p.Age;
            return View();
        }

        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();
            people.Add(new PersonModel { FirstName = "Hani", Age = 38, LastName = "Ebrahimi" });
            people.Add(new PersonModel { FirstName = "Joe", Age = 48, LastName = "Doe" });
            people.Add(new PersonModel { FirstName = "Sara", Age = 28, LastName = "Conor" });
            people.Add(new PersonModel { FirstName = "Tim", Age = 18, LastName = "Moo" });
            return View(people);
        }
    }
}