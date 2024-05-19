using MVC_CHANGE_PASSWORD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CHANGE_PASSWORD.Controllers
{
    public class CPController : Controller
    {
        MVC_CHANGE_PASSWORDEntities _db = new MVC_CHANGE_PASSWORDEntities();
        // GET: CP
        public ActionResult AddCP()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCP(ChangePassword _cp)
        {
            if(_cp.newpassword == _cp.confirmpassword)
            {
                int ID = Convert.ToInt32(Session["IDD"]);
                var data = _db.TBL_REGISTRATION.Find(ID);
                if(data.PASSWORD == _cp.oldpassword)
                {
                    data.PASSWORD = _cp.newpassword;
                    _db.Entry(data).State = System.Data.Entity.EntityState.Modified;
                    _db.SaveChanges();
                    ViewBag.msg = "Password has been changed successfully";
                }
                else
                {
                    ViewBag.msg = "Old Password do not match!!";
                }
            }
            else
            {
                ViewBag.msg = "Password do not match!!";
            }
            return View();
        }
    }
}