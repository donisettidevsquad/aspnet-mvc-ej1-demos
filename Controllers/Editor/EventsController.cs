﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class EditorController : Controller
    {
        //
        // GET: /EditorEvents/

        public ActionResult Events()
        {
            return View();
        }

    }
}