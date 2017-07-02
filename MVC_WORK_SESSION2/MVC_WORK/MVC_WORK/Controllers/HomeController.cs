using MVC_WORK.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_WORK.ViewModel;
using MVC_WORK.Interface;
namespace MVC_WORK.Controllers
{
    public class HomeController : Controller
    {
        private IAccountBookRepository AccountBookRepository;

        public HomeController()
        {
            this.AccountBookRepository = new AccountBookRepository();
        }

        [ValidateAntiForgeryToken] //資安防網路漏洞
        public ActionResult Index()
        {
            var query = AccountBookRepository.GetAll().ToList();  // db.AccountBook.OrderBy(x => x.Dateee).ToList();
            AccountBookViewModels ViewMode = new AccountBookViewModels();
            ViewMode.AccountBookData = query;
            ViewData["ViewDataTest"] = ViewMode;
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