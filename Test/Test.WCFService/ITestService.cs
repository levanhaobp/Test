using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Test.DCO;

namespace Test.WCFService
{
    [ServiceContract]
    public interface ITestService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/GetAllTestItem",
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        TestItemDRO GetAllTestItem(); 
    }
}
