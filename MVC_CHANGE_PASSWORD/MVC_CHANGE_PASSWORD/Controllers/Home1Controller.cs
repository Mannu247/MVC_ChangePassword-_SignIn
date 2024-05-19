using MVC_CHANGE_PASSWORD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CHANGE_PASSWORD.Controllers
{
    public class Home1Controller : Controller
    {
        MVC_CHANGE_PASSWORDEntities _db = new MVC_CHANGE_PASSWORDEntities();
        // GET: Home1
        public ActionResult AddHome()
        {
            int ID = Convert.ToInt32(Session["IDD"]);
            var data = _db.TBL_REGISTRATION.Where(x => x.RID == ID).ToList();
            return View(data);
        }
    }
}