using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace totalemployeewage
{
    internal  class uc1_employee
    {
        public void ToCheckEmpAttendence()
        {
            int Is_Fulltime = 1;
            Random random = new Random();
            int emplCheck = random.Next(0, 2);
            if (emplCheck == 1)
            {
                Console.WriteLine("employee is present");
            }
            else
            {
                Console.WriteLine("employee is absent");
            }
        }
    }
}
