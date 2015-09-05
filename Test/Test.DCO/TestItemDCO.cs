using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Test.DCO
{
    [DataContract]
    public class TestItemDCO
    {
        [DataMember]
        public string TestID { get; set; }

        [DataMember]
        public string TestName { get; set; }

        [DataMember]
        public string TestDescription { get; set; }
    }

    [DataContract]
    //Data Response Object (DRO)
    public class TestItemDRO
    {
        [DataMember]
        public List<TestItemDCO> TestItemList { get; set; }
    }
}
