using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_WORK.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            List <Models.AccountingDataViewModel> AccountData = new List<Models.AccountingDataViewModel>();
            AccountData.Add(new Models.AccountingDataViewModel { DATE = "106/06/01", MONEY = "1000", TYPE = "支出" });
            AccountData.Add(new Models.AccountingDataViewModel { DATE = "106/06/03", MONEY = "1500", TYPE = "支出" });
            AccountData.Add(new Models.AccountingDataViewModel { DATE = "106/06/13", MONEY = "500", TYPE = "支出" });

            ViewData["ViewDataTest"] = AccountData;
            ViewData["Page"] = "1";
            ViewData["Size"] = "20";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}