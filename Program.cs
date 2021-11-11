using System;
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

            //Console.WriteLine("Welcome to the Employee Wage computation program");            
            //Variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int maxHrs = 0;
            int maxDay = 0;

           while(maxHrs < MAX_HRS_IN_MONTH && maxDay < NUM_OF_WORKING_DAYS)  //while loop to check which condition meets first
            {
                maxDay++;

                Random random = new Random(); //Random object creation

                //Computation
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        //Console.WriteLine("Employee is Part time");
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        //Console.WriteLine("Employee is Fulltime");
                        break;
                    default:
                        empHrs = 0;
                        //Console.WriteLine("Employee is Absent");
                        break;


                }
                maxHrs += empHrs; //incrementing employee hours
                empWage = empHrs * EMP_RATE_PER_HOUR; 
                totalEmpWage += empWage;
                Console.WriteLine("Day {0} and hours {1}",maxDay,maxHrs);
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            totalEmpWage += empWage;
            Console.WriteLine("Total Employee Wage : " + totalEmpWage);
            

            Console.WriteLine("Welcome to the Employee Wage computation program");
            Console.ReadLine();

        }
    }
}
