using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorExample.Controllers //Use project name instead of RazorExample
{
    public class Section2Controller : Controller //Use Controller name instead of Section2Controller
    {
        // GET: Section2
        public ActionResult section2() //Use corresponding .cshtml filename instad of section2
        {
            return View();
        }
    }
}