using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebContextSample.Services
{
    public class TestService : ITestService
    {
        public string HelloWorld()
        {
            return "Hello World !";
        }
    }
}