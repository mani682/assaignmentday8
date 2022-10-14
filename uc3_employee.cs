using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace totalemployeewage
{
    internal class uc3_employee
    {
        public  void ToCalculateEmpWage()
        {
            int Is_Full_Time = 1;
            int Is_PartTime = 2;
            int EmpWage_PerHr = 20;
            int empHrs = 0;
            int empWages = 0;
            Random random = new Random();
            int emplCheck = random.Next(2);
            if (emplCheck == Is_Full_Time)
            {
                empHrs = 8;
            }
            else if (emplCheck == Is_PartTime)
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }
            empWages = empHrs * EmpWage_PerHr;
            Console.WriteLine("employee daily wages are :" + empWages);

        }
    }
}
