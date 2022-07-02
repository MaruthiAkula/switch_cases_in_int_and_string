using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_cases_in_int_and_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int Totalbill = 0;
        Start:
            Console.WriteLine("Please Enter your coffee size : 1s,2m,3l");
            int userdecision = int.Parse(Console.ReadLine());
            switch (userdecision) {
                case 1 :
                    Totalbill += 1;
                    break;
                case 2:
                    Totalbill += 2;
                    break;
                case 3:
                    Totalbill += 3;
                    break;
                default:
                    Console.WriteLine("Enter Valid Size");
                    goto Start;
            }
            decision:
            Console.WriteLine("you Want Another Coffee ...YES or NO exactly ");
            string decision = Console.ReadLine();
            switch (decision)
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Enter Yes Or No");
                    goto decision;
            }
            Console.WriteLine("Thank U for shopping with us");
            Console.WriteLine("Your Bill={0}", Totalbill);

                // Totalbill += 1;

        }


    }
}



    
