using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfContextSample.Modules;

namespace WcfContextSample.Contracts
{
    [ServiceContract]
    public interface IPropertyInjectionService
    {
        [OperationContract]
        TestModel GetModel();
    }
}
