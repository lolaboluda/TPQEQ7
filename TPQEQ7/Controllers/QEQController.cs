﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TPQEQ7.Models;

namespace TPQEQ7.Controllers
{
    public class QEQController : Controller
    {

        // GET: QEQ
        public ActionResult Index()
        {
            Usuario USER = new Usuario();
            Session["Usuario"] = USER;
            return View();
        }
    }
}