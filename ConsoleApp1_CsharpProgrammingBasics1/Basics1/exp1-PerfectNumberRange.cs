using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_CsharpProgrammingBasics1.Basics1
{
   public  class exp1_PerfectNumberRange
    {
        public static void DisplayPerfect()
        {
            Console.WriteLine(" Enter a range of two numbers  ");
            int low = int.Parse(Console.ReadLine());
            int high = int.Parse(Console.ReadLine());
            int result = 0;
            int rem = 0;
         

            for(int num=low; num<=high; num++)
            {
                int originalnum = num;

                for (int j=1; j < originalnum;j++)
                {
                    rem = originalnum % j;
                    if (rem==0)
                    {
                        result = result + j;
                    }
                }
                if(result==originalnum)
                {
                    Console.WriteLine("                   PERFECT NUMBER  " + originalnum);
                }
                else
                {
                    Console.WriteLine(" NUMBER is NOT PERFECR" +originalnum );
                }

                result = 0;

            }



        }
    }
}
