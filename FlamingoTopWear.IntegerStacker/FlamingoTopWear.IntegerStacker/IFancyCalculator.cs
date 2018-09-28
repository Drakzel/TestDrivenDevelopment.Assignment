using System;
using System.Collections.Generic;
using System.Text;

namespace FlamingoTopWear.IntegerStacker
{
    public interface IFancyCalculator
    {
        double? Top();
        double? SecondTop();
        void Pop();
        void Push(double num);
        int Size();
        void Clear();
        void Add();
        void AddAll();
        void Subtract();
        void Multiply();
        void MultiplyAll();
        void Divide();
        List<double> GetCalc();
    }
}
