﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class AjaxController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [OutputCache(NoStore=true, Duration=0)]
        public string GetTime()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fffff");
        }
    }
}