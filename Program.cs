using Microsoft.VisualBasic;

namespace EmployeeWageComputationProblem
{
    Console.WriteLine("Welcome to Employee Wage Computation Problem!");
    public class PresentApsent
    {
        public static void main(string[] args)
        {
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
        }



    }