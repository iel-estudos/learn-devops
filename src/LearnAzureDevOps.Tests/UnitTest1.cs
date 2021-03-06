using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnAzureDevOps.Pages;

namespace LearnAzureDevOps.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var test = new ErrorModel();

            Assert.IsFalse(test.ShowRequestId);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var test = new ErrorModel();
            test.RequestId = "14252411";
            Assert.IsTrue(test.ShowRequestId);
        }
    }
}
