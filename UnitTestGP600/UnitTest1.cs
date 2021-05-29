using DiCon;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestGP600
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestErrorCodes()
        {
            Assert.AreEqual("No Error", Gp600.ErrorCodes.ErrorMessage(0));
            Assert.IsNull(Gp600.ErrorCodes.ErrorMessage(uint.MaxValue));
        }
    }
}
