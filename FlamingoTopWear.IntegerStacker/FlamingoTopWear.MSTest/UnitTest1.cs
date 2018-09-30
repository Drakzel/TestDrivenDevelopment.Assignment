using FlamingoTopWear.IntegerStacker;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FlamingoTopWear.MSTest
{
    [TestClass]
    public class UnitTest1
    {
        #region PushTesting
        [TestMethod]
        public void TestPush()
        {
            IFancyCalculator x = new FancyCalculator();
            var stack = x.GetStack();

            x.Push(45);
            Assert.IsTrue(stack.Count == 1);
            Assert.IsTrue(stack.Contains(45));
        }

        [TestMethod]
        public void TestPushOptions()
        {
            IFancyCalculator x = new FancyCalculator();

            x.Push(45);
            x.Push(35);
            x.Push(25);
            x.Push(15);
            Assert.IsTrue(x.Top() == 15);
            x.Pop();
            Assert.IsTrue(x.Top() == 25);
            x.Push(150);
            Assert.IsTrue(x.Top() == 150);
        }

        #endregion

        #region TopTesting
        [TestMethod]
        public void TestTop()
        {
            IFancyCalculator x = new FancyCalculator();

            x.Push(45);
            Assert.AreEqual(x.Top(), 45);

            x.Push(25);
            Assert.AreNotEqual(x.Top(), 45);
        }

        [TestMethod]
        public void TestTopFailureToRespond()
        {
            IFancyCalculator x = new FancyCalculator();
            Assert.IsNull(x.Top());
        }

        #endregion

        #region SecondTopTesting
        [TestMethod]
        public void TestSecondTop()
        {
            IFancyCalculator x = new FancyCalculator();

            x.Push(25);
            x.Push(10);
            x.Push(15);
            Assert.IsTrue(x.SecondTop() == 10);
        }

        [TestMethod]
        public void TestSecondTopFailureToRespond()
        {
            IFancyCalculator x = new FancyCalculator();
            Assert.IsNull(x.SecondTop());
        }
        #endregion

        #region PopTesting
        [TestMethod]
        public void TestPop()
        {
            IFancyCalculator x = new FancyCalculator();
            var stack = x.GetStack();

            x.Push(45);
            Assert.IsTrue(stack.Count == 1);
            x.Pop();
            Assert.IsTrue(stack.Count == 0);

        }

        [TestMethod]
        public void TestPopOptions()
        {
            IFancyCalculator x = new FancyCalculator();
            

            for (int i = 1; i <= 3; i++) { x.Push(i); }
            Assert.IsTrue(x.Size() == 3);
            Assert.IsTrue(x.Top() == 3);

            x.Pop();
            Assert.IsTrue(x.Top() == 2);

            for (int i = 1; i <= 3; i++) { x.Push(i+3); }
            Assert.IsTrue(x.Top() == 6);
            Assert.IsTrue(x.Size() == 5);

            x.Pop();
            Assert.IsTrue(x.Size() == 4);

            x.Pop();
            Assert.IsTrue(x.Size() == 3);
            Assert.IsTrue(x.Top() == 4);
        }

        #endregion

        #region SizeTesting
        [TestMethod]
        public void TestSize()
        {
            IFancyCalculator x = new FancyCalculator();
            var stack = x.GetStack();

            x.Push(25);
            Assert.AreEqual(stack.Count, x.Size());
            Assert.AreEqual(x.Size(), 1);
            x.Push(25);
            Assert.AreEqual(stack.Count, x.Size());
            Assert.AreEqual(x.Size(), 2);
            x.Push(25);
            Assert.AreEqual(stack.Count, x.Size());
            Assert.AreEqual(x.Size(), 3);
        }
        #endregion

        #region ClearTesting
        [TestMethod]
        public void TestClear()
        {
            IFancyCalculator x = new FancyCalculator();
            var stack = x.GetStack();

            x.Push(25);
            x.Push(45);
            Assert.IsTrue(stack.Count == 2);
            x.Clear();
            Assert.IsTrue(stack.Count == 0);
        }
        #endregion

        #region AddTesting
        [TestMethod]
        public void TestAdd()
        {
            IFancyCalculator x = new FancyCalculator();
            var stack = x.GetStack();
            
            Assert.IsTrue(stack.Count == 0);
            x.Push(10);
            x.Push(20);
            x.Push(30);
            x.Push(40);
            x.Add();
            Assert.IsTrue(x.Top() == 70);
        }

        [TestMethod]
        public void TestAddAll()
        {
            IFancyCalculator x = new FancyCalculator();

            x.Push(10);
            x.Push(10);
            x.Push(10);
            Assert.IsTrue(x.Top() == 10);
            x.AddAll();
            Assert.IsTrue(x.Top() == 30);
        }
        #endregion

        #region SubtractionTesting
        [TestMethod]
        public void TestSubtract()
        {
            IFancyCalculator x = new FancyCalculator();

            Assert.IsTrue(x.Size() == 0);
            x.Push(10);
            x.Push(20);
            x.Push(30);
            x.Push(40);
            x.Subtract();
            Assert.IsTrue(x.Top() == 10);
        }
        #endregion

        #region MulitplyTesting
        [TestMethod]
        public void TestMultiply()
        {
            IFancyCalculator x = new FancyCalculator();
            var calc = x.GetStack();

            Assert.IsTrue(x.Size() == 0);
            x.Push(10);
            x.Push(20);
            x.Push(30);
            x.Push(40);
            x.Multiply();
            Assert.IsTrue(x.Top() == 1200);
            x.Multiply();
            Assert.IsTrue(x.Top() == 24000);
        }

        [TestMethod]
        public void TestMultiplyAll()
        {
            IFancyCalculator x = new FancyCalculator();

            x.Push(10);
            x.Push(10);
            x.Push(10);
            x.Push(10);
            Assert.IsTrue(x.Top() == 10);
            x.MultiplyAll();
            Assert.IsTrue(x.Top() == 10000);
        }
        #endregion

        #region DivisionTesting
        [TestMethod]
        public void TestDivision()
        {
            IFancyCalculator x = new FancyCalculator();

            x.Push(2);
            x.Push(4);
            x.Push(2);
            x.Divide();
            Assert.IsTrue(x.Top() == 0.5);
            x.Divide();
            Assert.IsTrue(x.Top() == 0.125);
        }
        #endregion
    }
}