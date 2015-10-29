using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfContextSample.Modules;

namespace WcfContextSample.Contracts
{
    [ServiceContract]
    public interface IClassicInjectionService
    {
        [OperationContract]
        TestModel GetModel();
    }
}
