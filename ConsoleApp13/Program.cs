using ConsoleApp13.CSHARP7;
using ConsoleApp13.CSHARP8;
using System;
using System.Linq;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //bool isLivingInBangalore = PropertyPattern.IsLivinginBangalore(new Address("Bangalore", ""));
            //Console.WriteLine(isLivingInBangalore);


            //bool isLivingInBangalore = DeconstructPattern.IsLivingInBangaloreNew(new Address("Bangalore", ""));
            //Console.WriteLine(isLivingInBangalore);

            object[] newObject = new object[] { 1, "Paddy", 2.36, true, null, 2};

            foreach (var item in newObject)
            {
                Console.WriteLine(SwitchExpression.DoAllSwitch(item)); 
            } 
            //foreach (var item in newObject)
            //{
            //    IsinSwitch.DoSwitchNewWayConditional(item);
            //}

            //foreach (var item in newObject)
            //{
            //    IsTypePattern.GetNumber(item);
            //}

        }

    }

    
}
