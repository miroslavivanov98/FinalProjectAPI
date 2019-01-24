using BodyCalculatorWeb.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BodyCalculatorWeb.Controllers
{
    public class CalculateController : Controller
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        // GET: Calculate
        public ActionResult Index()
        {
            DLL.Results.Calculate("190", "80", "male");
            return View();
        }
        [HttpPost]
        public ActionResult Calculate()
        {
            try
            {
                string height = Request["value1"];
                string weight = Request["value2"];
                string gender = Request["gender"];
                var values = DLL.Results.Calculate(height, weight, gender);
                ViewBag.values = values;
                return View();

            }
            catch (FormatException ex)
            {
                ViewBag.error = "Invalid parameters";
                logger.Error("Parameters are missing or not entered.");
                return View();
            }
        }

    }
}