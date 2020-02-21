using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13.CSHARP7
{
    class IsinSwitch
    {
        public static void DoSwitchOldWay(object obj)
        {
            switch (obj)
            {
                case "Paddy":
                    Console.WriteLine($"Its an string {((string)obj).ToLower()}");
                    break;
                case 1:
                    Console.WriteLine($"Its an int {((int)obj) + 2}");
                    break;
                case 2.36:
                    Console.WriteLine($"Its an double {((double)obj) + 2.06}");
                    break;
                case true:
                    Console.WriteLine($"Its an bool {((bool)obj)}");
                    break;
                default:
                    throw new Exception("Invalid data");
            }
        }

        public static void DoSwitchNewWay(object obj)
        {
            switch (obj)
            {
                case string s:
                    Console.WriteLine($"Its an string {s.ToLower()}");
                    break;
                case int i:
                    Console.WriteLine($"Its an int {i + 2}");
                    break;
                case double d:
                    Console.WriteLine($"Its an double {d + 2.06}");
                    break;
                case bool b:
                    Console.WriteLine($"Its an bool {b}");
                    break;
                default:
                    throw new Exception("Invalid data");
            }
        }

        public static void DoSwitchNewWayConditional(object obj)
        {
            switch (obj)
            {
                case string s when s == "Paddy":
                    Console.WriteLine($"Its an string {s.ToLower()}");
                    break;
                case int i when i == 1:
                    Console.WriteLine($"Its an int {i + 2}");
                    break;
                case double d when d == 2.36:
                    Console.WriteLine($"Its an double {d + 2.06}");
                    break;
                case bool b when b:
                    Console.WriteLine($"Its an bool {b}");
                    break;
                case null:
                    Console.WriteLine($"OMG its a null");
                    break;
                default:
                    throw new Exception("Invalid data");
            }
        }
    }
}
