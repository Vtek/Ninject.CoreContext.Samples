using WebContextSample.Filters;
using WebContextSample.Models;
using WebContextSample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebContextSample.Controllers.api
{
    public class ApiPropertyInjectionController : ApiController
    {
        public ITestService TestService { get; set; }

        [TestApiFilter]
        public TestModel Get()
        {
            return new TestModel
            {
                Value = TestService.HelloWorld()
            };
        }
    }
}
