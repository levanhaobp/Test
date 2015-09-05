using Microsoft.ServiceModel.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Web;

namespace Test.WCFService.CustomHost
{
    public class InitTestService : ServiceHostFactoryBase
    {
        public override ServiceHostBase CreateServiceHost(string service, Uri[] baseAddresses)
        {
            TestService.AutoMapper();
            TestService.Autofac();
            WebServiceHost2 serviceHost = new WebServiceHost2(typeof(TestService), true, baseAddresses);
            //serviceHost.Interceptors.Add(new BasicRequestInterceptor(new AuthenticationServiceStub("helldemons", "_P@ssw0rds"), "iPOS"));

            return serviceHost;
        }
    }
}