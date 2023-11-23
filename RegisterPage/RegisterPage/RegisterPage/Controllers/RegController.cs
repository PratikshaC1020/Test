using RegisterPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace RegisterPage.Controllers
{
    public class RegController : Controller
    {
        // GET: Reg
        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]

        public ActionResult SignIn(Register reg)
        {
            string FirstName = reg.Firstname;
            string LastName = reg.Lastname;
            string Email = reg.Email;
            string Password = reg.Password;
            string confirmPassword = reg.confirmPassword;
            bool ShowSubscribe=reg.ShowSubscribe;
            var result =  "Form submitted Successfully";
            return Json(result, JsonRequestBehavior.AllowGet);
           
        }
    }
}