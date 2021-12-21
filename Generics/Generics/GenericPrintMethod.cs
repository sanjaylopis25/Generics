using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class GenericPrintMethod
    {
        public static void ToPrint<T>(T[] array)
        {
            foreach (var element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}
