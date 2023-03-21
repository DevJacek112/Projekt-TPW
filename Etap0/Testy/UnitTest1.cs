using View;



namespace Testy {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestMethod1() {
            Assert.IsTrue(true);
            Assert.AreEqual(1,1);
        }
        [TestMethod]
        public void TestMethod2() {
            Assert.IsFalse(false);
        }
    }
}