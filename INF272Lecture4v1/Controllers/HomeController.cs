using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INF272Lecture4v1.Controllers
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

        //Action called form1 accepts parameters and assign it to ViewBag objects to be dispayed in the Contact page
        /* [HttpPost]
         public ActionResult form1(string fName, string lName, int age, string isAlive)
         {

             ViewBag.FirstName = fName;
             ViewBag.LastName = lName;
             ViewBag.Age = age;

             if (isAlive != null)

                 ViewBag.IsAlive = "Alive";
             else
                 ViewBag.IsAlive = "Not Alive";

             return View("Contact");
         }
        */
         //Action called form2 accepts an object and assign its properties to ViewBag objects to be dispayed in the Contact page
         [HttpPost]
         public ActionResult form2(Models.PersonModel pm)
         {
             ViewBag.StudentNumber = pm.StudentNumber;
             ViewBag.FirstName = pm.FirstName;
             ViewBag.LastName = pm.LastName;
             ViewBag.EmailAddress = pm.EmailAddress;
             ViewBag.myLink = pm.myLink;



             return View("Contact");
         }
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