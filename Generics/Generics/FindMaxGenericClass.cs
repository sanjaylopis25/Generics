using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class FindMaxGenericClass<T> where T: IComparable
    {
        T first, second, third;
        public FindMaxGenericClass(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        public static T FindMaxIntNumber(T first, T second, T third)
        {
            if ((first.CompareTo(second) > 0) && (first.CompareTo(third) > 0))
            {
                return first;
            }
            else if ((second.CompareTo(first) > 0) && (second.CompareTo(third) > 0))
            {
                return second;
            }
            else if ((third.CompareTo(first) > 0) && (third.CompareTo(second) > 0))
            {
                return third;
            }
            else
            {
                Console.WriteLine("All 3 Numbers have same value");
                return default;
            }
        }
        public void MaxMethod()
        {
            Console.WriteLine("Maximum Value is :" + FindMaxIntNumber(first, second, third));
        }
    }
}
