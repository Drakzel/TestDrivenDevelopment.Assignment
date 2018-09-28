using System;
using System.Collections.Generic;
using System.Linq;

namespace FlamingoTopWear.IntegerStacker
{
    public class FancyCalculator : IFancyCalculator
    {
        List<double> Calculator = new List<double>();

        #region Push, Pop, Top, SecondTop
        public void Push(double num)
        {
            Calculator.Add(num);
        }

        public double? Top()
        {
            if(Calculator.Count < 1) { return null; }
            double num;
            return num = Calculator.Last();
        }

        public double? SecondTop()
        {
            if (Calculator.Count < 1) { return null; }
            double num;
            return num = Calculator[Calculator.Count - 2];
        }

        public void Pop()
        {
            var toRemove = Calculator[Calculator.Count - 1];
            Calculator.Remove(toRemove);
        }
        #endregion

        #region Calculator, Size, Clear
        List<double> IFancyCalculator.GetCalc()
        {
            return Calculator;
        }

        public int Size()
        {
            return Calculator.Count;
        }

        public void Clear()
        {
            Calculator.Clear();
        }
        #endregion

        #region Addition Methods
        public void Add()
        {
            var item1 = Top();
            var item2 = SecondTop();
            var total = item1 + item2;
            Pop();
            Pop();
            Push(Convert.ToDouble(total));
        }

        public void AddAll()
        {
            for (int i = 0; i < Calculator.Count; i++)
            {
                if (Calculator.Count < 2) { break; }
                var item1 = Top();
                var item2 = SecondTop();
                var total = item1 + item2;
                Pop();
                Pop();
                Push(Convert.ToDouble(total));
            }
        }
        #endregion

        #region Subtraction Methods
        public void Subtract()
        {
            var item1 = Top();
            var item2 = SecondTop();
            var total = item1 - item2;
            Pop();
            Pop();
            Push(Convert.ToDouble(total));
        }
        #endregion

        #region Multiplication Methods
        public void Multiply()
        {
            var item1 = Top();
            var item2 = SecondTop();
            var total = item1 * item2;
            Pop();
            Pop();
            Push(Convert.ToDouble(total));
        }

        public void MultiplyAll()
        {
            for (int i = -1; i < Calculator.Count; i++)
            {
                if (Calculator.Count < 2) { break; }
                var item1 = Top();
                var item2 = SecondTop();
                var total = item1 * item2;
                Pop();
                Pop();
                Push(Convert.ToDouble(total));
            }
        }
        #endregion

        #region Division Methods
        public void Divide()
        {
            var item1 = Top();
            var item2 = SecondTop();
            var total = item1 / item2;
            Pop();
            Pop();
            Push(Convert.ToDouble(total));
        }
        #endregion
    }
}
