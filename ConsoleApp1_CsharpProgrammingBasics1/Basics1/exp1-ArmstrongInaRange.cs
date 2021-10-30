using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_CsharpProgrammingBasics1.Basics1
{
    public class exp1_ArmstrongInaRange
    {
        public static void ArmstronginaRange()
        {
            Console.WriteLine(" Enter the two ranges ");
            int low = int.Parse(Console.ReadLine());
            int high = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int result = 0;
           
            for (int num= low+1;num<high;num++)
            {
                int OriginalNum = num;
                int Number = num;

                while(OriginalNum !=0)
                {
                    OriginalNum = OriginalNum / 10;
                    count++;
                }
                Console.WriteLine(" The Number {0}  had {1} digits ",num,count);
                //int cnt = count;
                OriginalNum = num;
                while (OriginalNum!=0)
                {
                    int rem = OriginalNum % 10;                   
                    result = result + (int)Math.Pow(rem, count);
                    OriginalNum = OriginalNum / 10;

                }
                if (result == num)
                {
                    Console.WriteLine("                             ** The number {0} is  ARMSTRONG ", num);
                    Console.WriteLine("                             ** ARMSTRONG " + Number);
                }

                else
                {
                    Console.WriteLine(" The Number {0} NOT ARMSTRONG ", num);
                    Console.WriteLine(" NOT armstrong " + Number);
                }

                result = 0;
                count = 0;
            }




        }
    }
}
