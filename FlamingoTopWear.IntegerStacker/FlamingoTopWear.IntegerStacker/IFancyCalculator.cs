using System;
using System.Collections.Generic;
using System.Text;

namespace FlamingoTopWear.IntegerStacker
{
    public interface IFancyCalculator
    {
        /// <summary>
        /// Get the top value of the stack
        /// </summary>
        /// <returns>returns the latest value added to the stack or null if stack is empty</returns>
        double? Top();

        /// <summary>
        /// Get the second top value, of the stack
        /// </summary>
        /// <returns>returns the second latest value added to the stack or null if stack is empty</returns>
        double? SecondTop();

        /// <summary>
        /// Removes the latest value of the stack
        /// </summary>
        void Pop();

        /// <summary>
        /// Adds any numerical to the stack.
        /// </summary>
        /// <param name="num">double value will be added to stack</param>
        void Push(double num);

        /// <summary>
        /// Gets the size of the stack
        /// </summary>
        /// <returns>Returns integer, representing total stack count</returns>
        int Size();

        /// <summary>
        /// Removes all values of stack
        /// </summary>
        void Clear();

        /// <summary>
        /// Top two values of the stack, are added together
        /// </summary>
        void Add();

        /// <summary>
        /// All values of the stack, are added together
        /// </summary>
        void AddAll();

        /// <summary>
        /// Top two values of the stack, are subtracted
        /// </summary>
        void Subtract();

        /// <summary>
        /// Top two values of the stack, are multiplied
        /// </summary>
        void Multiply();

        /// <summary>
        /// All values of the stack, are multiplied
        /// </summary>
        void MultiplyAll();

        /// <summary>
        /// Top two values of the stack, are divided
        /// </summary>
        void Divide();

        /// <summary>
        /// Gets the 
        /// </summary>
        /// <returns></returns>
        List<double> GetStack();
    }
}
