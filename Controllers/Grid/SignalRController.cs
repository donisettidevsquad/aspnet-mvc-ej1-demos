﻿using MVCSampleBrowser.Models;
using Syncfusion.JavaScript;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class GridController : Controller
    {
        //
        // GET: /SignalR/

        public ActionResult SignalR()
        {
            var DataSource = OrderRepository.GetAllRecords().ToList();
            ViewBag.datasource = DataSource;
            return View();
        }
    }
}