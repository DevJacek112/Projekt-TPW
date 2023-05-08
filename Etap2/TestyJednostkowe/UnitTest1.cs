using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace TestyJednostkowe {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestMethod1() {
            Ellipse circle = new Ellipse();

            circle.Width = 2;
            circle.Height = 2;
            // Debug.WriteLine(circle.Width + " " + circle.Height);    
            Assert.AreEqual(circle.Width, 2);
            Assert.AreEqual(circle.Height, 2);
        }
        [TestMethod]
        public void TestMethod2() {
            Canvas canvas = new Canvas();
            Logika.Controller.spawnCircles(5, canvas);
            Process currentProcess2 = Process.GetCurrentProcess();
            int threadCount2 = currentProcess2.Threads.Count;
            Debug.WriteLine(threadCount2);
            Assert.IsTrue(threadCount2 < 50);
        }
    }
}
