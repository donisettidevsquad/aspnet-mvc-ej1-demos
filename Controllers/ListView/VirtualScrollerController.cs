﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers.ListView
{
    public partial class ListViewController : Controller
    {
        //
        // GET: /VirtualScroller/

        public ActionResult VirtualScrolling()
        {
            return View();
        }

    }
}
