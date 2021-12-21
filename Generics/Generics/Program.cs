using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 10, 20, 30, 40 };
            PrintArray.ToPrint(intArray);

            double[] doubleArray = { 10.24, 20.23, 30.76, 40.78 };
            PrintArray.ToPrint(doubleArray);

            char[] charArray = { 'H', 'E', 'L', 'L', 'O'};
            PrintArray.ToPrint(charArray);

            Console.WriteLine("=========================================");
            Console.WriteLine("Printing all Array using Generic Method concept");
            GenericPrintMethod.ToPrint<int>(intArray);
            GenericPrintMethod.ToPrint<double>(doubleArray);
            GenericPrintMethod.ToPrint<char>(charArray);
            Console.WriteLine("=========================================");
            Console.WriteLine("Max Numbers out of 3 Numbers");FindMaximumValue.FindMaxIntNumber(10, 20, 30);

            new FindMaxGenericClass<int>(10, 20, 30).MaxMethod();
            float x = 10.25f, y = 10.25f, z = 10.25f;
            string p = "abc", q = "ahj", r = "abk";
            new FindMaxGenericClass<float>(x, y, z).MaxMethod();
            new FindMaxGenericClass<string>(p, q, r).MaxMethod();

            int[] arr = { 10, 30, 12, 45 };
            new FindMaxUsingBuiltinMethod<int>(arr).PrintMax();
        }
    }
}
