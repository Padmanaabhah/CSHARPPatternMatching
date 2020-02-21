using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13.CSHARP7
{
    class IsTypePattern
    {
        public static void GetNumberOldWay(object obj)
        {
            if (obj is int)
            {
                int i = (int)obj;
                Console.WriteLine($"Its an Int {i + 2}");
            }
            else if (obj is bool)
            {
                bool b = (bool)obj;
                Console.WriteLine($"Its an bool {b}");
            }
            else if (obj is double)
            {
                double d = (double)obj;
                Console.WriteLine($"Its an double {d + 0.2}");
            }
            else if (obj is string)
            {
                string s = Convert.ToString(obj);
                Console.WriteLine($"Its an string {s.ToLower()}");
            }
        }

        public static void GetNumber(object obj)
        {
            if (obj is int i)
            {
                Console.WriteLine($"Its an Int {i}");
            }
            else if (obj is bool b)
            {
                Console.WriteLine($"Its an bool {b}");
            }
            else if (obj is double d)
            {
                Console.WriteLine($"Its an double {d}");
            }
            else if (obj is string s)
            {
                Console.WriteLine($"Its an string {s}");
            }
        }
    }
}
