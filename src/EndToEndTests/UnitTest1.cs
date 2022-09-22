namespace EndToEndTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //30s
            System.Threading.Thread.Sleep(30000);
            Assert.IsTrue(true);
        }
    }
}