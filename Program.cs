﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage_Day4
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Welcome to Employee wage computation ");
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;

            //Variables declaration
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random(); //Random object creation     

            //Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage: " + empWage);
         
           Console.ReadLine();
        }
    }
}
