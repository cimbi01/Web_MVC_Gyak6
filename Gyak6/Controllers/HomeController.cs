using Gyak6.Data_Access_Layer;
using Gyak6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gyak6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            RandomModelContext randomModelContext = new RandomModelContext();
            RandomModel randomModel = new RandomModel() {Integer = 1, Character = '1', ID=1, String="1" };
            for (int i = 0; i < 3; i++)
            {
                randomModelContext.RandomModels.Add(randomModel);
            }
            randomModelContext.SaveChanges();
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