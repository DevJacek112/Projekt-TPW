using Logika;
using System.Windows.Shapes;

namespace Testy {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestMethod1() {
            Assert.AreEqual(1, 1);  
            
            Ellipse circle = new Ellipse();
            
            circle.Width = 2;
            circle.Height = 2;
           // Debug.WriteLine(circle.Width + " " + circle.Height);    
            Assert.AreEqual(circle.Width, 2);
            Assert.AreEqual(circle.Height, 2);
        }
        /*[TestMethod]
        public void TestMethod2() {
            Logika.Controller.spawnCircles(5, new System.Windows.Controls.Canvas());
            Process currentProcess = Process.GetCurrentProcess();
            int threadCount = currentProcess.Threads.Count;
            Assert.AreEqual(threadCount, 6);
        }*/
    }
}