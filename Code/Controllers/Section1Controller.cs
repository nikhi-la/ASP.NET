using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorExample.Controllers //Use project name instead of RazorExample
{
    public class Section1Controller : Controller //Use Controller name instead of Section1Controller
    {
        // GET: Section1
        public ActionResult section1() //Use corresponding .cshtml filename instad of section1
        {
            return View();
        }
    }
}