using System.ComponentModel.Design;

namespace Class02_Exercises_1_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class02 Exercises");

            //Exercise 01;
            double numberOne = 47.666D;
            double numberTwo = 12.32D;

            double result = numberOne / numberTwo;
            Console.WriteLine($"The result is: {result}");


            int integerNumberOne = 8;
            int integerNumberTwo = 5;

            float integerNumberResult = integerNumberOne / (float)integerNumberTwo;
            Console.WriteLine($"The integer numbers result is: {integerNumberResult}");

            //Exercise 02;

            string firstString = "Hello ";
            string secondString = "World";

            string resultString = firstString + secondString;
            Console.WriteLine(resultString);

            string thirdString = "9";
            string fourthString = "3";

            string concatinationResult = thirdString + fourthString;
            Console.WriteLine(concatinationResult);

            //Exercise 03;

            int integerVariable = 18;
            string stringVariable = "Hello I am ";

            string ex3Result = stringVariable + integerVariable.ToString();
            Console.WriteLine(ex3Result);

            //Exercise 04;
            // You have n credits on your mobile bill. One SMS costs m credits.
            // How many SMS messages you can send ?

            int n = 102;
            int m = 5;

            int smsResult = n / m;
            Console.WriteLine($"We can send {smsResult} SMS messages");

            //Exercise 05;

            int apples = 8;
            int basketForApples = 5;

            Console.WriteLine("Please enter a number of trees");
            string usersInput = Console.ReadLine();

            int parsedTrees = Convert.ToInt32(usersInput);


            int numberOfApplesOnTrees = apples * parsedTrees;
            Console.WriteLine($"There are {numberOfApplesOnTrees} apples combined from all of the trees");

            int basketsThatHoldTheApples = numberOfApplesOnTrees / basketForApples;
            Console.WriteLine($"To collect all the apples from the trees we will need {basketsThatHoldTheApples} baskets");

            //Exercise 06;

            int num1;
            int num2;


            Console.Write("Enter a number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter one more number: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("The larger number is: " + num1);
                if (num1 % 2 == 0)
                {
                    Console.WriteLine(num1 + " is even.");
                }
                else
                {
                    Console.WriteLine(num1 + " is odd.");
                }
            }
            else if (num2 > num1)
            {
                Console.WriteLine("The larger number is: " + num2);
                if (num2 % 2 == 0)
                {
                    Console.WriteLine(num2 + " is even.");
                }
                else
                {
                    Console.WriteLine(num2 + " is odd.");
                }
            }
            else
            {
                Console.WriteLine("The two numbers are equal.");
            }

            // Exercise 07;

            Console.WriteLine("Please enter a number between 1-3");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Congrats! You won a car");
                    break;
                case "2":
                    Console.WriteLine("Congrats! You won a plane");
                    break;
                case "3":
                    Console.WriteLine("Congrats! You won a bike");
                    break;
                default:
                    Console.WriteLine("You need to enter number between 1 and 3");
                    break;
            }
        }
    }
}