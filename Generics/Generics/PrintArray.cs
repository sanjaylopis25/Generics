using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class PrintArray
    {
        public static void ToPrint(int[] array)
        {
            foreach(int element in array)
            {
                Console.WriteLine(element);
            }
        }
        public static void ToPrint(double[] array)
        {
            foreach (double element in array)
            {
                Console.WriteLine(element);
            }
        }
        public static void ToPrint(char[] array)
        {
            foreach (char element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}
