using Syncfusion.EJ.ReportWriter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class ReportWriterController : Controller
    {
        // GET: DrillThrough
        public ActionResult DrillThrough()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult DrillThrough(string writerFormat)
        {
            try
            {
                string fileName = null;
                WriterFormat format;
                HttpContext httpContext = System.Web.HttpContext.Current;
                ReportWriter reportWriter = new ReportWriter();
                reportWriter.ReportProcessingMode = ProcessingMode.Local;
                reportWriter.ReportPath = Server.MapPath("~/App_Data/Reports/DrilThrough.rdlc");

                if (writerFormat == "PDF")
                {
                    fileName = "DrilThrough.pdf";
                    format = WriterFormat.PDF;
                }
                else if (writerFormat == "Word")
                {
                    fileName = "DrilThrough.doc";
                    format = WriterFormat.Word;
                }
                else if (writerFormat == "Html")
                {
                    fileName = "DrilThrough.Html";
                    format = WriterFormat.HTML;
                }
                else
                {
                    fileName = "DrilThrough.xls";
                    format = WriterFormat.Excel;
                }
                reportWriter.Save(fileName, format, httpContext.Response);
            }
            catch { }

            return View();
        }
    }
}