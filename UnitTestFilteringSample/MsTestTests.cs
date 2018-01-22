using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFilteringSample
{
    [TestClass]
    public class MsTestTests
    {
        [TestMethod]
        [TestCategory("MsTestCategory1")]
        public void MsTestMethod1()
        {
        }

        [TestMethod]
        [TestCategory("MsTestCategory2")]
        public void MsTestMethod2()
        {
        }
    }
}
