using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;

namespace ResourcesGlobalization.Mvc.Controllers
{
    public class GlobalizationController : Controller
    {
        // GET: Globalization
        [HttpGet]
        public ActionResult Index()
        {
            decimal valor = Convert.ToDecimal(4530.56);
            DateTime data = new DateTime(2017, 4, 21);

            var ciBr = new CultureInfo("pt-br");

            ViewBag.Valor = valor.ToString("c",ciBr);
            ViewBag.Data = data.ToString("D",ciBr);

            var ci = new CultureInfo("en-us");

            ViewBag.ValorUs = valor.ToString("c", ci);
            ViewBag.DataUs = data.ToString("D", ci);


            return View();
        }
    }
}