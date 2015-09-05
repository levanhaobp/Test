using Autofac;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using Test.DAO;
using Test.DCO;
using Test.DTO;

namespace Test.WCFService
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple,
        InstanceContextMode = InstanceContextMode.PerCall)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class TestService : ITestService
    {
         private static IContainer Container { get; set; }

        public TestService()
        {
            using (var scope = Container.BeginLifetimeScope())
            {
            }
        }

        public static void AutoMapper()
        {
            Mapper.CreateMap<TestItemDTO, TestItemDCO>();
            Mapper.CreateMap<TestItemDCO, TestItemDTO>();

            Mapper.AssertConfigurationIsValid();
        }

        public static void Autofac()
        {
            var afBuilder = new ContainerBuilder();
            afBuilder.RegisterType<TestItemDAO>().As<ITestItemDAO>();

            Container = afBuilder.Build();
        }

        public DCO.TestItemDRO GetAllTestItem()
        {
            DCO.TestItemDRO resutl = new TestItemDRO();
            try
            {
                using (var scope = Container.BeginLifetimeScope())
                {
                    var db = scope.Resolve<ITestItemDAO>();
                    var temp = db.GetTestItemList();

                    if (temp != null && temp.Count > 0)
                    {
                        resutl.TestItemList = Mapper.Map<List<TestItemDCO>>(temp);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return resutl;
        }
    }
}
