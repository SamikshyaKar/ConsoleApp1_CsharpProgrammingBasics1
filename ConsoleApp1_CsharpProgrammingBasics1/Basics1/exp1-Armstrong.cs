using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_CsharpProgrammingBasics1.Basics1
{
   public  class exp1_Armstrong
    {
      public static void Display_Armstrong()
        {
            Console.WriteLine(" Enter a Number ");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            int Number = num;

            while (num!=0)
            {
                num = num / 10;
                count++;

            }
            //Console.WriteLine(" The Order of the number " + num + " " + "is" + " "  + count);
            //Console.WriteLine($" The number of digits of the Number   {num, 10} is {count, 10} ", num, count);
            Console.WriteLine(" The Order of the Given number is {0}" , count);
            Console.WriteLine(" The Order of the Given number is " +  count);

            int result = 0;
            int mul = 1;
            int cnt = count;
            while(num !=0)
            {
                int rem = num % 10;
                while(cnt !=0)
                {
                    mul = mul * rem;
                    cnt--;
                }
                result = result + mul;
                num = num / 10;
                mul = 1;
                cnt = count;
            }

            Console.WriteLine();
            if(result==Number)
            {
                Console.WriteLine(" The Num  is an ArmStrong Number " +Number);
            }
            else
            {

                Console.WriteLine(" The Number is not an Armstrong number "+ Number);
            }
        }

       
    }
}
