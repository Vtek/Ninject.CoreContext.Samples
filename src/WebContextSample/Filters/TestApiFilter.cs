using WebContextSample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;

namespace WebContextSample.Filters
{
    public class TestApiFilter : ActionFilterAttribute
    {
        public ITestService TestService { get; set; }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            TestService.HelloWorld();
            base.OnActionExecuted(actionExecutedContext);
        }
    }
}