using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class FindMaximumValue
    {
        public static void FindMaxIntNumber(int first, int second, int third)
        {
            if((first.CompareTo(second) > 0) && (first.CompareTo(third) > 0))
            {
                Console.WriteLine(first); 
            }
            else if ((second.CompareTo(first) > 0) && (second.CompareTo(third) > 0))
            {
                Console.WriteLine(second);
            }
            else if ((third.CompareTo(first) > 0) && (third.CompareTo(second) > 0))
            {
                Console.WriteLine(third);
            }
            else
            {
                Console.WriteLine("All 3 Numbers have same value");
                
            }
        }
    }
}
