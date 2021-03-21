using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace SGpostMailData.Controllers
{
    public class UserViewController : Controller
    {
        // GET: User
        public ActionResult Index()  
        {
            return View();
        }
        
        public ActionResult ViewSheet(string mail)
        {
            using( var client = new HttpClient())
            {
                client.BaseAddress = new Uri("");
            }
            return View();
        }

    }
}