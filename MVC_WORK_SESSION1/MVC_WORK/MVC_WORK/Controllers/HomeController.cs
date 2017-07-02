using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_WORK.ViewModel;

namespace MVC_WORK.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            List <ViewModel.AccountingDataViewModel> AccountData = new List<ViewModel.AccountingDataViewModel>();
            AccountData.Add(new ViewModel.AccountingDataViewModel { DATE = "106/06/01", MONEY = "1000", AccountTYPE = "支出" });
            AccountData.Add(new ViewModel.AccountingDataViewModel { DATE = "106/06/03", MONEY = "1500", AccountTYPE = "支出" });
            AccountData.Add(new ViewModel.AccountingDataViewModel { DATE = "106/06/13", MONEY = "500", AccountTYPE = "支出" });

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