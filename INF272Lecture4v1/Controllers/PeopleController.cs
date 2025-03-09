using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace INF272Lecture4v1.Controllers
{
    public class PeopleController : Controller
    {
        // GET: Students

        public ActionResult PeopleView()
        {
            List<Models.PersonModel> students = new List<Models.PersonModel>();

            students.Add(new Models.PersonModel { StudentNumber = "u21648345", FirstName = "Marvelous", LastName = "Dube", EmailAddress = "u21648345@tuks.co.za", myLink = "~/HTML/Person01.html" });
            students.Add(new Models.PersonModel { StudentNumber = "u22730797", FirstName = "Lereko", LastName = "Thokoa", EmailAddress = "u22730797@tuks.co.za", myLink = "~/HTML/Person02.html" });
            students.Add(new Models.PersonModel { StudentNumber = "u23657597", FirstName = "Declan", LastName = "van Wyk", EmailAddress = "u23657597@tuks.co.za", myLink = "~/HTML/Person03.html" });
            students.Add(new Models.PersonModel { StudentNumber = "u21516643", FirstName = "Mpho", LastName = "Kuda", EmailAddress = "u21516643@tuks.co.za", myLink = "~/HTML/Person04.html" });
            students.Add(new Models.PersonModel { StudentNumber = "u23719223", FirstName = "Lebogang", LastName = "Chauke", EmailAddress = "u23719223@tuks.co.za", myLink = "~/HTML/Person05.html" });

            return View(students);

        }
    }
}
