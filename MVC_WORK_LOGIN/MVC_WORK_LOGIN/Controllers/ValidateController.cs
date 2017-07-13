using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_WORK_LOGIN.Controllers
{
    public class ValidateController : Controller
    {
        public JsonResult CheckLogin(string login_id)
        {
            bool isValidate = true;
            if (login_id.IndexOf("skilltree") != -1 || login_id.IndexOf("demo") != -1 || login_id.IndexOf("twMVC") != -1)
            {
                isValidate = false;
            }
            return Json(isValidate, JsonRequestBehavior.AllowGet);
        }
       
    }
}