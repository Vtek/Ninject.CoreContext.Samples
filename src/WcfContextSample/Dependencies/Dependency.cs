using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfContextSample.Dependencies
{
    public class Dependency : IDependency
    {
        public string HelloWorld()
        {
            return "Hello world !";
        }
    }
}