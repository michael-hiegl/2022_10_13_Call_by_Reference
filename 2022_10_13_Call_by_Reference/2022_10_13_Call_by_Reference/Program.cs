//Imports######################################################
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//#############################################################

//Classes######################################################
//#############################################################

namespace _2022_10_13_Call_by_Reference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Code#############################################
            int Wert1 = 10;
            int Wert2 = 20;

            Console.WriteLine($"Wert1: {Wert1}, Wert2: {Wert2}");

            Swap(ref Wert1, ref Wert2);

            Console.WriteLine($"Wert1: {Wert1}, Wert2: {Wert2}");
            //#################################################

            Console.WriteLine("Press ENTER to exit...");
            Console.ReadKey();
        }

        //Functions############################################
        static void Swap(ref int a, ref int b)
        {
            int temp = 0;
            temp = a;
            a = b;
            b = temp;
        }
        //#####################################################
    }
}
