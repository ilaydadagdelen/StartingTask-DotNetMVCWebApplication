using StartingTask.Models;
using System.Diagnostics;
using System.Linq;
using System.Web.Mvc;

namespace StartingTask.Controllers
{
    public class SignUpController : Controller
    {
        IMPStartingTaskDB db = new IMPStartingTaskDB();

        // GET: SignUp
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(UserSignup us)
        {
            if (ModelState.IsValid)
            {
                if (db.UserSignups.Any(x => x.Email == us.Email))
                {
                    ViewBag.Message = "Email zaten kayıtlı";
                    return View();
                }
                else
                {
                    db.UserSignups.Add(us);
                    db.SaveChanges();
                    Response.Write("<script>alert('Kayıt başarılı')</script>");
                    return RedirectToAction("Login");
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(Login l)
        {
            var user = db.UserSignups.FirstOrDefault(m => m.Email == l.Email && m.Password == l.Password);

            if (user != null)
            {
                if (user.UserID == 2)
                {
                    Session["UserName"] = user.Username;
                    Session["UserEmail"] = user.Email;
                    return RedirectToAction("Index", "Subject");

                }
                else
                {
                    Session["UserName"] = user.Username;
                    Session["UserEmail"] = user.Email;
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ViewBag.Message = "Geçersiz email veya şifre!";
                return View();
            }
        }


        public ActionResult LogOut()
        {
            Session.Clear();
            Session.Abandon();
            Response.Write("<script>alert('Başarıyla çıkış yapıldı.')</script>");
            return RedirectToAction("Login", "SignUp"); 


        }
    }
}
