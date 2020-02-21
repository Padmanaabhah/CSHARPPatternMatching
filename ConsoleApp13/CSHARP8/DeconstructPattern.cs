using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13.CSHARP8
{
    class DeconstructPattern
    { 
        public static bool IsLivingInBangalore(Address a)
        {
            if(a != null && a.City == "Bangalore")
            {
                return true;
            }
            return false;
        }
        
        //public static bool IsLivingInBangaloreNew(Address a)
        //{
        //    return a is ("Bangalore", _);
        //}
    }


}

