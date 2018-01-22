using NUnit.Framework;

namespace UnitTestFilteringSample
{
    [TestFixture]
    public class NunitTests
    {
        [Test]
        [Category("NunitCategory1")]
        public void NunitMethod1()
        {
        }

        [Test]
        [Category("NunitCategory2")]
        public void NunitMethod2()
        {
        }
    }
}
