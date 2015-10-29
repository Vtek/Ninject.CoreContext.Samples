using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfContextSample.Dependencies;
using WcfContextSample.Modules;

namespace WcfContextSample.Contracts
{
    public class PropertyInjectionService : IPropertyInjectionService
    {
        public IDependency Dependency { get; set; }

        public TestModel GetModel()
        {
            return new TestModel
            {
                Value = Dependency.HelloWorld()
            };
        }
    }
}