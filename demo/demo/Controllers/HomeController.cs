using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Info inff = new Info()
            {
                Name = "Sumiya Hur tasnim",
                Email = "21-44851-2@student.aiub.edu",
                Phone = "019XXXXXYYY",
                Degree = "BSc. in CSE",
                Expertise = "Javascript, PHP"
            };

            ViewBag.Inff = new Info[] { inff };
            return View();
        }

        public ActionResult Education()
        {
            Education hsc = new Education()
            {
                Year = 2019,
                Group = "Science",
                Institute = "XXX YYYY ZZZ"
            };

            Education ssc = new Education()
            {
                Year = 2017,
                Group = "Science",
                Institute = "abs school"
            };

            ViewBag.edu = new Education[] { hsc, ssc };

            return View();
        }

        public ActionResult Projects()
        {
            Project p1 = new Project()
            {
                Title = "Airticket Management System",
                Desc = "XXX YYY ZZZ KKK LLL MMM",
                Course = "OOP1"
            };

            Project p2 = new Project()
            {
                Title = "ed tech managment system",
                Desc = "XXX YYY ZZZ KKK LLL MMM",
                Course = "OOP2"
            };

            Project p3 = new Project()
            {
                Title = "split gun",
                Desc = "XXX YYY ZZZ KKK LLL MMM",
                Course = "HCI"
            };

            Project p4 = new Project()
            {
                Title = "knn Detection Using Image Processing",
                Desc = "XXX YYY ZZZ KKK LLL MMM",
                Course = "ML"
            };

            Project p5 = new Project()
            {
                Title = "Job Portal",
                Desc = "XXX YYY ZZZ KKK LLL MMM",
                Course = "Web Tech"
            };

            ViewBag.pr = new Project[] { p1, p2, p3, p4, p5 };
            return View();
        }

        public ActionResult References()
        {
            Ref r1 = new Ref()
            {
                Name = "XXX YYY ZZZ",
                Desig = "Professor, Dept. of FST , AIUB"
            };

            Ref r2 = new Ref()
            {
                Name = "KKLL HHHJJK",
                Desig = "Asst. Prof., Dept. of FST , AIUB"
            };

            Ref r3 = new Ref()
            {
                Name = "KOOOO PPPP FF",
                Desig = "Professor, Dept. of FST , AIUB"
            };

            ViewBag.reff = new Ref[] { r1, r2, r3 };
            return View();
        }

        public ActionResult Certificates()
        {

            return View();
        }
    }
}