using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EnterpriseFinalProject.Data_Access;
using EnterpriseFinalProject.DAL;

namespace EnterpriseFinalProject.Controllers
{
    public class HomeController : Controller
    {
        private Data_Context DB = new Data_Context();

        public ActionResult Index()
        {
            Data_Initializer myInit = new Data_Initializer();
            myInit.Populate(DB);
            ViewBag.Text = "TESTING";
            ViewBag.Players = DB.Players.ToList();
            return View(DB.Players.ToList());
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