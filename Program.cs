using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter 1st subject marks");
            int mark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd subject marks");
            int mark2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd subject marks");
            int mark3 = Convert.ToInt32(Console.ReadLine());

            int total = mark + mark2 + mark3;
            float avg = total / 300f;
            float per = avg*100;
            Console.WriteLine("percentage is:"+ per);

            if(per>=75)
            {
                Console.WriteLine("grade is:A");
            }
            else if(per>=50 && per < 75)
            {
                Console.WriteLine("grade is: B");
            }
            else if(per<50 && per>=40)
            {
                Console.WriteLine("grade is: C");
            }
            else
            {
               Console.WriteLine("grade is: Fail");
            }

        }
    }
}
