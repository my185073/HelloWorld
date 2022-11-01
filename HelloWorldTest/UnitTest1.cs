using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace HelloWorldTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Assert.IsTrue(HellowWorld.Program.test());

        }
    }
}
