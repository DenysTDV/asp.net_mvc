using Easy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
namespace Easy.Controllers
{
    public class HomeController : Controller
    {
        
        private CarDBContext db = new CarDBContext();
        public ActionResult Index()
        {
            return View();
        }
        
    }
}