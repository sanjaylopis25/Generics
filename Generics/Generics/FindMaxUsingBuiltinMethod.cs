using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class FindMaxUsingBuiltinMethod<T>
    {
        public T[] values;

        public FindMaxUsingBuiltinMethod(params T[] values)
        {
            this.values = values;
        }
        public void ArraySort(T[] values)
        {
            Array.Sort(values);
        }
        public T FindMax()
        {
            Array.Sort(this.values);
            return this.values[values.Length - 1];
        }
        public void PrintMax()
        {
            Console.WriteLine("Max Vaue is :"+FindMax());
        }
    }
}
