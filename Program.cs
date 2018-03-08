using System;

namespace task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Please enter your final course mark");
            Console.WriteLine("------------------------------------------");
            var pass = 50;
            int mark = Convert.ToInt32(Console.ReadLine());
            if (mark >= pass)
            {
                Console.WriteLine("Well done you passed");
            }

            else
            {
                Console.WriteLine("Sorry you did not pass");

            }
            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("**************PROGRAM END***************");
            Console.WriteLine("Please Press <Enter> to quit the program");
            Console.ReadKey();
            //done//

        }
    }
}
