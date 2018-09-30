using System;
using System.Collections.Generic;
using System.Linq;

namespace FlamingoTopWear.IntegerStacker
{
    public class FancyCalculator : IFancyCalculator
    {
        List<double> Stack = new List<double>();

        #region Push, Pop, Top, SecondTop
        public void Push(double num)
        {
            Stack.Add(num);
        }

        public double? Top()
        {
            if(Stack.Count < 1) { return null; }
            double num;
            return num = Stack.Last();
        }

        public double? SecondTop()
        {
            if (Stack.Count < 1) { return null; }
            double num;
            return num = Stack[Stack.Count - 2];
        }

        public void Pop()
        {
            var toRemove = Stack[Stack.Count - 1];
            Stack.Remove(toRemove);
        }
        #endregion

        #region Calculator, Size, Clear
        List<double> IFancyCalculator.GetStack()
        {
            return Stack;
        }

        public int Size()
        {
            return Stack.Count;
        }

        public void Clear()
        {
            Stack.Clear();
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
            for (int i = 0; i < Stack.Count; i++)
            {
                if (Stack.Count < 2) { break; }
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
            for (int i = -1; i < Stack.Count; i++)
            {
                if (Stack.Count < 2) { break; }
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
