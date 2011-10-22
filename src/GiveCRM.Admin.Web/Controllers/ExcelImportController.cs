﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GiveCRM.Admin.Web.Controllers
{
    public class ExcelImportController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            if (file.ContentLength <= 0)
            {
                return View();
            }

            return RedirectToAction("Index", "Dashboard");
        }
    }
}
