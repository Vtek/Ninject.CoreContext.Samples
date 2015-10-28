using WebContextSample.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebContextSample.Models;
using WebContextSample.Services;

namespace WebContextSample.Controllers
{
    public class MvcPropertyInjectionController : Controller
    {
        public ITestService TestService { get; set; }

        [HttpGet]
        [TestMvcFilter]
        public ActionResult Index()
        {
            return Json(new TestModel
            {
                Value = TestService.HelloWorld()
            }, JsonRequestBehavior.AllowGet);
        }
    }
}