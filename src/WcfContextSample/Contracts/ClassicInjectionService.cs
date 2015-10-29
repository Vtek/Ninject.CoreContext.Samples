using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfContextSample.Dependencies;
using WcfContextSample.Modules;

namespace WcfContextSample.Contracts
{
    public class ClassicInjectionService : IClassicInjectionService
    {
        IDependency Dependency { get; set; }

        public ClassicInjectionService(IDependency dependency)
        {
            Dependency = dependency;
        }

        public TestModel GetModel()
        {
            return new TestModel 
            { 
                Value = Dependency.HelloWorld()
            };
        }
    }
}