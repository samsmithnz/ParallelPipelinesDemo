namespace IntegrationTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //4s
            System.Threading.Thread.Sleep(4000);
            Assert.IsTrue(true);
        }
    }
}