﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace totalemployeewage
{
    internal class uc2_employee
    {
        public  void ToCheckCalWage()
        {
            int Is_Full_Time = 1;
            int Emp_Rate_PerHr = 20;
            int empHrs = 0;
            int empWages = 0;
            Random random = new Random();
            int emplCheck = random.Next(2);
            if (emplCheck == Is_Full_Time)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWages = empHrs * Emp_Rate_PerHr;
            Console.WriteLine("employee daily wages are :" + empWages);
        }
    }
}
