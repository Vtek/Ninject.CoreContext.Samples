using Ninject.CoreContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfContextSample.Dependencies;

namespace WcfContextSample
{
    public class TestModule : AutoInjectionModule
    {
        public override void Load()
        {
            Bind<IDependency>().To<Dependency>().InHttpScope();
        }
    }
}