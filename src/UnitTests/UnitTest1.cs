namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //0.1s
            System.Threading.Thread.Sleep(100);
            Assert.IsTrue(true);
        }
    }
}