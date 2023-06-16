using System;

namespace IradukundaLahaiRois_3875144_VRA704_Ass1
{
    class Program
    {

        public void Addition()
        {
            Console.WriteLine("Enter first number:");
            string firstNumber = Console.ReadLine();

            Console.WriteLine("Enter second number:");
            string secondNumber = Console.ReadLine();
            if (CheckNum(firstNum) == true && CheckNum(secondNum) == true)
            {
                int num1Converted = Convert.ToInt32(firstNum);
                int num2Converted = Convert.ToInt32(secondNum);
                Addition(num1Converted, num2Converted);
            }
            else
            {
                Console.WriteLine("Please enter numbers and not anything else.");
                RunAddition();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("SHARP");
            Console.WriteLine("1- Addition .");
            Console.WriteLine("2- Subtraction.");
            Console.WriteLine("3- Multiplication.");
            Console.WriteLine("4- Division.");
            Console.WriteLine("5- Square Root.");
            Console.WriteLine("6- Exponent.");
            string selection = Console.ReadLine();

            if (selection == "1")
            { Addition();
            }
            else if (selection == "2")
            {
                Substraction();
            }

            else if (selection == "3")
            { MUltiplication();
            }
            else if (selection == "4")
            { Division();
            }


          
















        }

    }
}
