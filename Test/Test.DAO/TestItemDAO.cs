using System;
using System.Collections.Generic;
using Test.DTO;

namespace Test.DAO
{
    public interface ITestItemDAO
    {
        List<TestItemDTO> GetTestItemList();
    }

    public class TestItemDAO : ITestItemDAO
    {
        public List<TestItemDTO> GetTestItemList()
        {
            return new List<TestItemDTO>
            {
                new TestItemDTO{
                    TestID = "1",
                    TestName = "Test name 1",
                    TestDescription = "Test description 1"
                },
                new TestItemDTO{
                    TestID = "2",
                    TestName = "Test name 2",
                    TestDescription = "Test description 2"
                },
                new TestItemDTO{
                    TestID = "3",
                    TestName = "Test name 3",
                    TestDescription = "Test description 3"
                },
                new TestItemDTO{
                    TestID = "4",
                    TestName = "Test name 4",
                    TestDescription = "Test description 4"
                }
            };
        }
    }
}
