using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_CsharpProgrammingBasics1.Basics1
{
    public class exp2_SwitchGen
    {
        public static void displayswitch()
        {

            int x = 20;

            switch (x)

            {

                case 10:

                    Console.WriteLine("x value is 10");

                    break;

                case 15:

                    Console.WriteLine("x value is 15");

                    break;

                case 20:

                    Console.WriteLine("x value is 20");

                    break;

                default:

                    Console.WriteLine("Not Known");

                    break;

            }

            Console.WriteLine("Press Enter Key to Exit..");

            Console.ReadLine();


        }
    }
}
