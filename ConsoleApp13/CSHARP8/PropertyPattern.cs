using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13.CSHARP8
{
    class PropertyPattern
    {
        public static bool IsLivinginBangalore(Address a)
        {
            return a is { City: "Bangalore" };
        }
    }
}
