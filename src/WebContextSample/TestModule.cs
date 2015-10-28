using Ninject.CoreContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebContextSample.Services;

namespace WebContextSample
{
    public class TestModule : AutoInjectionModule
    {
        public override void Load()
        {
            Bind<ITestService>().To<TestService>().InHttpScope();
        }
    }
}