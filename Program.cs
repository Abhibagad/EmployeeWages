using Microsoft.VisualBasic;

namespace EmployeeWageComputationProblem
{
    // Console.WriteLine("Welcome to Employee Wage Computation Problem!");
    public class PresentApsent
    {

        public static void main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem!");

            Random r = new Random();
            int genRand = r.Next(0, 2);
            if (genRand == 0)
            {
                Console.WriteLine("EMP is PRESENT");
            }
            else
            {
                Console.WriteLine("EMP IS APSENT");
            }
            Console.WriteLine("Random Number = " + genRand);



            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();

            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }

            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("emp Wage:" + empWage);
        }


    }
}