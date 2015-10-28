using WebContextSample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebContextSample.Filters
{
    public class TestMvcFilter : ActionFilterAttribute
    {
        public ITestService TestService { get; set; }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            TestService.HelloWorld();
            base.OnActionExecuted(filterContext);
        }
    }
}