using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinqSamp;
namespace LinqSampTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var repo = new Repository();
            repo.Run();

        }
    }
}
