using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageOops
{
    public class EmployeeAttendance


    {
       public static int CheckAttendance(int Employeee)
        {
            Random random = new Random();
            int check = random.Next(2);
            if (Employeee == check)
            {
                Console.WriteLine("\n employee is present");


            }
            else
            {
                Console.WriteLine("\n employee is absent");
            }
            return check;
        }
    }
}
