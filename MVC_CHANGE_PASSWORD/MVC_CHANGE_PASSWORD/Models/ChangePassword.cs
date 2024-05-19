using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_CHANGE_PASSWORD.Models
{
    public class ChangePassword
    {
            public string oldpassword { get; set; }
            public string newpassword { get; set; }
            public string confirmpassword { get; set; }
    }
}