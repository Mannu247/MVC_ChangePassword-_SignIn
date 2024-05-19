using MVC_CHANGE_PASSWORD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CHANGE_PASSWORD.Controllers
{
    public class RegistrationController : Controller
    {
        MVC_CHANGE_PASSWORDEntities _db = new MVC_CHANGE_PASSWORDEntities();
        // GET: Registration
        public ActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(TBL_REGISTRATION _reg)
        {
            _db.TBL_REGISTRATION.Add(_reg);
            _db.SaveChanges();
            return View();
        }
        public ActionResult ShowUser()
        {
            var data = _db.TBL_REGISTRATION.ToList();
            return View(data);
        }
    }
}