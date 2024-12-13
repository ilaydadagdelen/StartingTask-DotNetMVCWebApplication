using StartingTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StartingTask.Controllers
{
    public class HomeController : Controller
    {
        private IMPStartingTaskDB db = new IMPStartingTaskDB();

        // GET: Home
        public ActionResult Index()
        {
            var model = db.Subjects.ToList();
            return View(model);
        }

        public ActionResult Profile()
        {
            string userName = Session["UserName"] as string;
            string userEmail = Session["UserEmail"] as string;

            ViewBag.UserName = userName;
            ViewBag.UserEmail = userEmail;

            return View();
        }


    }
}