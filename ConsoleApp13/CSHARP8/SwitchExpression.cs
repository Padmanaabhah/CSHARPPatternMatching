using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13.CSHARP8
{
    class SwitchExpression
    {
        public static string DoAllSwitch(object a) {
            string result;
            switch (a)
            {               
                case string s:
                    result = $"This is a string value {s}";
                    break;
                case double d:
                    result = $"this is a double value {d}";
                    break;
                case bool b:
                    result = $"This is a boolean {b}";
                    break;
                case int i:
                    switch (i)
                    {
                        case 2:
                            result = $"This is an special int value {i.ToString()}";
                            break;
                        default:
                            result = $"This is an int value {i.ToString()}";
                            break;
                    }
                    break;
                default:
                    result = "Empty value";
                    break;
            }

            return result;
        }
     
    public static string DoAllNewSwitch(object a) =>
        
            a switch
            {
                string s => $"This is a string value {s}",
                double d => $"this is a double value {d}",
                bool b => $"This is a boolean {b}",
                int i => i switch
                {
                    _ when i == 2 => $"This is an special int value {i.ToString()}",
                    _ => $"This is an int value {i.ToString()}"
                },
                _ => "Empty value",
            };        
    }
}
