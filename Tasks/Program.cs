using System;
using System.Drawing;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Primitive types
            Console.WriteLine("Primitive Types:");
            bool boolVar = true;
            char charVar = 'c';
            int intVar = 10;
            long longVar = 10000000000;
            double doubleVar = 3.14;
            float floatVar = 3.14f;
            string stringVar = "Hello";

            Console.WriteLine(boolVar);
            Console.WriteLine(charVar);
            Console.WriteLine(intVar);
            Console.WriteLine(longVar);
            Console.WriteLine(doubleVar);
            Console.WriteLine(floatVar);
            Console.WriteLine(stringVar);

            // Type conversions
            Console.WriteLine("Type Conversion:");
            string strNum = "123";
            int intNum = int.Parse(strNum);
            Console.WriteLine(intNum);

            intNum = 456;
            string strNum2 = intNum.ToString();
            Console.WriteLine(strNum2);

            string strLong = "100000000000";
            long longNum = long.Parse(strLong);
            Console.WriteLine(longNum);

            longNum = 200000000000;
            string strLong2 = longNum.ToString();
            Console.WriteLine(strLong2);

            string strDouble = "3.14";
            double doubleNum = double.Parse(strDouble);
            Console.WriteLine(doubleNum);

            doubleNum = 2.718;
            string strDouble2 = doubleNum.ToString();
            Console.WriteLine(strDouble2);

            string strFloat = "3.14";
            float floatNum = float.Parse(strFloat);
            Console.WriteLine(floatNum);

            floatNum = 2.718f;
            string strFloat2 = floatNum.ToString();
            Console.WriteLine(strFloat2);

            string strBool = "True";
            bool boolValue = bool.Parse(strBool);
            Console.WriteLine(boolValue);

            boolValue = false;
            string strBool2 = boolValue.ToString();
            Console.WriteLine(strBool2);

            // int to long conversion
            int intNum2 = 123;
            long longNum2 = intNum2;
            Console.WriteLine(longNum2);

            long longNum3 = 10000000000;
            int intNum3 = (int)longNum3;
            Console.WriteLine(intNum3);

            // char to ASCII int conversion
            char charVar2 = 'A';
            int asciiCode = (int)charVar2;
            Console.WriteLine(asciiCode);

            asciiCode = 65;
            char charVar3 = (char)asciiCode;
            Console.WriteLine(charVar3);

            // Operators
            Console.WriteLine("Operators:");
            int num1 = 10;
            int num2 = 3;

            int sum = num1 + num2;
            Console.WriteLine(sum);

            int difference = num1 - num2;
            Console.WriteLine(difference);

            int product = num1 * num2;
            Console.WriteLine(product);

            int quotient = num1 / num2;
            Console.WriteLine(quotient);

            int remainder = num1 % num2;
            Console.WriteLine(remainder);

            int bitwiseOr = num1 | num2;
            Console.WriteLine(bitwiseOr);

            int bitwiseXor = num1 ^ num2;
            Console.WriteLine(bitwiseXor);

            int bitwiseAnd = num1 & num2;
            Console.WriteLine(bitwiseAnd);

            // Conditional statements
            Console.WriteLine("Conditional Statements:");
            int age = 20;

            if (age < 18)
            {
                Console.WriteLine("You are not eligible to vote.");
            }
            else if (age >= 18 && age < 21)
            {
                Console.WriteLine("You can vote but cannot  Marry .");
            }
            else
            {
                Console.WriteLine("Yes , You can vote and Marry");
            }

            // Logical operators && and ||
            Console.WriteLine("Logical Operators:");
            int num3 = 5;
            int num4 = 10;
            int num5 = 15;
            if (num3 < num4 && num4 < num5)
            {
                Console.WriteLine("num3 is less than num4 and num4 is less than num5.");
            }

            if (num3 > num4 || num4 > num5)
            {
                Console.WriteLine("At least one of the conditions is true.");
            }

            // Ternary operator
            Console.WriteLine("Ternary Operators:");
            int age1 = 20;
            string message = (age1 < 18) ? "You are not eligible to vote." : "You can vote.";
            Console.WriteLine(message);

            Console.WriteLine("// Comments");
            // Comments
            // This is a single-line comment

            /*
            This is a
            multi-line
            comment
            */

            /// <summary>
            /// This is an XML documentation comment
            /// </summary>

            // Loops
            // for loop
            Console.WriteLine("For Loop:");
            for (int i = 50; i <= 100; i++)
            {
                if (i == 95) // skip 95
                {
                    continue;
                }
                Console.Write(i + " ");
                if (i == 99) // break at 99
                {
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("While Loop:");

            // while loop
            int j = 50;
            while (j <= 100)
            {
                if (j == 95) // skip 95
                {
                    j++;
                    continue;
                }
                Console.Write(j + " ");
                if (j == 99) // break at 99
                {
                    break;
                }
                j++;
            }

            Console.WriteLine();

            Console.WriteLine("Do-While loop:");

            // do-while loop
            int k = 50;
            do
            {
                if (k == 95) // skip 95
                {
                    k++;
                    continue;
                }
                Console.Write(k + " ");
                if (k == 99) // break at 99
                {
                    break;
                }
                k++;
            } while (k <= 100);

            Console.WriteLine();

            // foreach loop (using a collection of integers)
            Console.WriteLine("For Each Loop:");
            List<int> numbers = Enumerable.Range(50, 100).ToList();
            foreach (int number in numbers)
            {
                if (number == 95) // skip 95
                {
                    continue;
                }
                Console.Write(number + " ");
                if (number == 99) // break at 99
                {
                    break;
                }
            }
            Console.WriteLine();

            // Switch case
            Console.WriteLine("Switch case:");
            int dayOfWeek = 3;
            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day of week");
                    break;
            }
 

        }
    }
}
    



