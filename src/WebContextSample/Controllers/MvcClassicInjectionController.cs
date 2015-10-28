using WebContextSample.Models;
using WebContextSample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebContextSample.Controllers
{
    public class MvcClassicInjectionController : Controller
    {
        ITestService TestService { get; set; }

        public MvcClassicInjectionController(ITestService testService)
        {
            TestService = testService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return Json(new TestModel
            {
                Value = TestService.HelloWorld()
            }, JsonRequestBehavior.AllowGet);
        }
    }
}