using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeewageRemap
{
    public class UC_1
    {
        public static void solution()
        {
            Console.WriteLine("Welcome to the employee wage problem");

            int isfulltime = 1;
            Random random
                = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == isfulltime)
            {

                Console.WriteLine("The employee is present");

            }
            else 
            {
                Console.WriteLine("The employee is absent");
            }


        }
    }
}
