using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MojaTestnaAzureAplikacija.Controllers
{
    public class LoremIpsumController : Controller
    {
        // GET: LoremIpsum
        public ActionResult Index()
        {
            return View();
        }
    }
}