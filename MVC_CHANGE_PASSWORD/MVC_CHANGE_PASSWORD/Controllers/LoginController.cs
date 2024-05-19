using MVC_CHANGE_PASSWORD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CHANGE_PASSWORD.Controllers
{
    public class LoginController : Controller
    {
        MVC_CHANGE_PASSWORDEntities _db = new MVC_CHANGE_PASSWORDEntities();

        // GET: Login
        [HttpGet]
        public ActionResult AddLogin()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddLogin(TBL_REGISTRATION _reg)
        {
            if (ModelState.IsValid)
            {
                var data = (from a in _db.TBL_REGISTRATION
                            where a.EMAIL == _reg.EMAIL && a.PASSWORD == _reg.PASSWORD
                            select a).ToList();
                if (data.Count > 0)
                {
                    Session["IDD"] = data[0].RID;
                    return RedirectToAction("AddHome", "Home1");
                }
                else
                {
                    ViewBag.msg = "Login Failed!!";
                }
            }
            return View(_reg);
        }
    }
}
