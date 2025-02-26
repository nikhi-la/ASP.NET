using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorExample.Controllers //Use project name instead of RazorExample
{
    public class Section3Controller : Controller //Use Controller name instead of Section3Controller
    {
        // GET: Section3
        public ActionResult section3() //Use corresponding .cshtml filename instad of section3
        {
            return View();
        }
    }
}