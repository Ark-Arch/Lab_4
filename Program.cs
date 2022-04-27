using System;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //DESCRIPTION OF THE PROGRAM
            Console.WriteLine(@"
            THIS PROGRAM IS A FUNCTION THAT INFORMS IF THE SUM OF OF YOUR INPUTTED VALUE IS LESS THAN 100 OR NOT"+"\n"
            +"lessThan100(x,y) ");
            

            // receiving rawInputs from the user
            Console.WriteLine("Please input your first value (x)");
            string rawInputA = Console.ReadLine();
            double cleanInputA;

            Console.WriteLine("Please input your second value (y)");
            string rawInputB = Console.ReadLine();
            double cleanInputB;


            bool testInputA = double.TryParse(rawInputA, out cleanInputA);
            bool testInputB = double.TryParse(rawInputB, out cleanInputB);

            if (!(testInputA && testInputB))
            {
                Console.WriteLine(@"
                INVALID INPUTS!. 
                (your inputs are either not numbers or they are out of range.");
            }
            else
            {
                bool condition = ((cleanInputA+cleanInputB) < 100);
                if (condition)
                {
                    Console.WriteLine("\n"+
                    @$"lessThan100({cleanInputA},{cleanInputB}) = {condition}"
                    );
                }
                else
                {
                    Console.WriteLine("\n"+
                    @$"lessThan100({cleanInputA},{cleanInputB}) = {condition}"
                    );
                }
            }
        }
    }
}