using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Resume.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Pdf()
        {
            var cd = new System.Net.Mime.ContentDisposition
            {
                FileName = @"thornton-resume.pdf", 
                Inline = false, 
            };
            Response.AppendHeader("Content-Disposition", cd.ToString());
            return File(@"..\Content\thornton-resume.pdf", "application/pdf");
        }
    }
}
