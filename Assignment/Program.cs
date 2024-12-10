using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 1-  Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            //Console.Write("Please Enter the Number : ");
            //if (int.TryParse(Console.ReadLine(), out int Number))
            //{
            //    if (Number % 3 == 0 && Number % 4 == 0)
            //    {
            //        Console.WriteLine("Yes");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input => Please enter a valid integer.");
            //}

            #endregion


            #region 2-  Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.

            //Console.Write("Please Enter the Number : ");
            //if (int.TryParse(Console.ReadLine(), out int Number))
            //{
            //    if (Number < 0)
            //    {
            //        Console.WriteLine("Negative");
            //    }
            //    else if (Number > 0)
            //    {
            //        Console.WriteLine("Positive");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Zero");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input => Please enter a valid integer.");
            //}

            #endregion


            #region 3-  Write a program that takes 3 integers from the user then prints the max element and the min element.

            //Console.Write("Please Enter the firt Number : ");
            //if (!int.TryParse(Console.ReadLine(), out int Number1))
            //{
            //    Console.WriteLine("Invalid input => Please enter a valid integer.");
            //    return;
            //}
            //Console.Write("Please Enter the Second Number : ");
            //if (!int.TryParse(Console.ReadLine(), out int Number2))
            //{
            //    Console.WriteLine("Invalid input => Please enter a valid integer.");
            //    return;
            //}
            //Console.Write("Please Enter the Third Number : ");
            //if (!int.TryParse(Console.ReadLine(), out int Number3))
            //{
            //    Console.WriteLine("Invalid input => Please enter a valid integer.");
            //    return;
            //}
            //if (Number1 > Number2 && Number1 > Number3)
            //{
            //    Console.WriteLine($"The Max Element is {Number1}");
            //}
            //else if (Number2 > Number1 && Number2 > Number3)
            //{
            //    Console.WriteLine($"The Max Element is {Number2}");
            //}
            //else 
            //{
            //    Console.WriteLine($"The Max Element is {Number3}");
            //}

            #endregion


            #region 4-  Write a program that allows the user to insert an integer number then check If a number is even or odd.

            //Console.Write("Please Enter the Number : ");
            //if (int.TryParse(Console.ReadLine(), out int Number))
            //{
            //    if (Number % 2 == 0)
            //    {
            //        Console.WriteLine("Even");
            //    }
            //    else 
            //    {
            //        Console.WriteLine("Odd");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input => Please enter a valid integer.");
            //}

            #endregion


            #region 5-  Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).

            //Console.Write("Please Enter the Char : ");
            //char.TryParse(Console.ReadLine(), out char Character);
            //switch (Character)
            //{
            //    case 'a':
            //    case 'e':
            //    case 'i':
            //    case 'o':
            //    case 'u':
            //    case 'A':
            //    case 'E':
            //    case 'I':
            //    case 'O':
            //    case 'U':
            //        Console.WriteLine("vowel");
            //        break;
            //    default:
            //        Console.WriteLine("consonant");
            //        break;
            //}


            /////// حل آخر
            //Console.Write("Please Enter the Char : ");
            //char.TryParse(Console.ReadLine(), out char Character);
            //if (Character == 'a' || Character == 'e' || Character == 'i' || Character == 'o' || Character == 'u' ||
            //    Character == 'A' || Character == 'E' || Character == 'I' || Character == 'O' || Character == 'U')
            //{
            //    Console.WriteLine("vowel");
            //}
            //else
            //{
            //    Console.WriteLine("consonant");
            //}



            #endregion


            #region  6-  Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            //Console.Write("Please Enter the Number : ");
            //if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
            //{
            //    for (int i = 1; i <= number; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a positive integer.");
            //}

            #endregion


            #region 7-  Write a program that allows the user to insert an integer then.

            //Console.Write("Please insert an integer : ");
            //int.TryParse(Console.ReadLine(), out int Number);
            //Console.WriteLine("************************");
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(Number * i);
            //}

            #endregion


            #region 8-  Write a program that allows to user to insert number then print all even numbers between 1 to this number.

            //Console.Write("Please insert an Even integer : ");
            //int.TryParse(Console.ReadLine(), out int Number);
            //Console.WriteLine("**********************");
            //for (int i = 2; i <= Number; i += 2)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion


            #region 9-  Write a program that takes two integers then prints the power.

            //Console.Write("Enter the First Number: ");
            //int.TryParse(Console.ReadLine(), out int x);

            //Console.Write("Enter the Second Number: ");
            //int.TryParse(Console.ReadLine(), out int y);

            //int result = 1;
            //for (int i = 0; i < y; i++) 
            //{
            //    result *= x;
            //}

            //Console.WriteLine($"Power: {result}");

            #endregion


            #region 10-  Write a program to enter marks of five subjects and calculate total, average and percentage.

            //Console.Write("Please Enter Mark1 : ");
            //int.TryParse(Console.ReadLine(), out int mark1);
            //Console.Write("Please Enter Mark2 : ");
            //int.TryParse(Console.ReadLine(), out int mark2);
            //Console.Write("Please Enter Mark3 : ");
            //int.TryParse(Console.ReadLine(), out int mark3);
            //Console.Write("Please Enter Mark4 : ");
            //int.TryParse(Console.ReadLine(), out int mark4);
            //Console.Write("Please Enter Mark5 : ");
            //int.TryParse(Console.ReadLine(), out int mark5);
            //Decimal sum = mark1 + mark2 + mark3 + mark4 + mark4;
            //Console.WriteLine($"sum= {sum}");
            //Decimal Average = sum / 5;
            //Console.WriteLine($"Average= {Average}");
            //Decimal Percentage = (sum / 500) * 100;
            //Console.WriteLine($"Percentage ={Percentage}");

            #endregion


            #region 11-  Write a program to input the month number and print the number of days in that month.

            //Console.Write("Please Enter the Month Number : ");
            //int.TryParse(Console.ReadLine(), out int Num);
            //switch (Num)
            //{
            //    case 1:
            //        Console.WriteLine(" the number of days in that month 31");
            //        break;
            //    case 2:
            //        Console.WriteLine("the number of days in that month 29");
            //        break;
            //    case 3:
            //        Console.WriteLine("the number of days in that month 31");
            //        break;
            //    case 4:
            //        Console.WriteLine("the number of days in that month 30");
            //        break;
            //    case 5:
            //        Console.WriteLine("the number of days in that month 31");
            //        break;
            //    case 6:
            //        Console.WriteLine("the number of days in that month 30");
            //        break;
            //    case 7:
            //        Console.WriteLine("the number of days in that month 31");
            //        break;
            //    case 8:
            //        Console.WriteLine("the number of days in that month 31");
            //        break;
            //    case 9:
            //        Console.WriteLine("the number of days in that month 30");
            //        break;
            //    case 10:
            //        Console.WriteLine("the number of days in that month 31");
            //        break;
            //    case 11:
            //        Console.WriteLine("the number of days in that month 30");
            //        break;
            //    default:
            //        Console.WriteLine("the number of days in that month 31");
            //        break;
            //}

            #endregion


            #region 12-  Write a program to create a Simple Calculator.

            //Console.Write("Please Enter the first Number : ");
            //int.TryParse(Console.ReadLine(), out int Num1);

            //Console.Write("please Enter the Second Number : ");
            //int.TryParse(Console.ReadLine(), out int Num2);

            //Console.WriteLine("please Enter the operation (+, -, *, /, %): ");
            //char.TryParse(Console.ReadLine(), out char operation);

            //switch (operation)
            //{
            //    case '+':
            //        Console.WriteLine($"sum = {Num1 + Num2}");
            //        break;
            //    case '-':
            //        Console.WriteLine($"Sub = {Num1 - Num2}");
            //        break;
            //    case '*':
            //        Console.WriteLine($"Multiply = {Num1 * Num2}");
            //        break;
            //    case '/':
            //        if (Num2 != 0)
            //        {
            //            Console.WriteLine($"Divides = {Num1 / Num2}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Cannot divide by zero");
            //        }
            //        break;
            //    case '%':
            //        Console.WriteLine($"modulus = {Num1 % Num2}");
            //        break;
            //    default:
            //        Console.WriteLine("Not Available");
            //        break;
            //}

            #endregion


            #region 13-  Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.WriteLine("please Enter the text: ");
            //string text = Console.ReadLine();
            //string reversed = "";
            //for (int i = text.Length - 1; i >= 0; i--)
            //{
            //    reversed += text[i];
            //}
            //Console.WriteLine("the reverse text: " + reversed);

            #endregion


            #region 14-  Write a program to allow the user to enter int and print the REVERSED of it.

            //Console.WriteLine("please Enter the Number: ");
            //string num = Console.ReadLine();
            //string reversed = "";
            //for (int i = num.Length - 1; i >= 0; i--)
            //{
            //    reversed += num[i];
            //}
            //Console.WriteLine("the reverse number: " + reversed);

            #endregion


            #region 15-  Write a program in C# Sharp to find prime numbers within a range of numbers.

            //Console.Write("Input starting number of range : ");
            //int start = int.Parse(Console.ReadLine());

            //Console.Write("Input ending number of range : ");
            //int end = int.Parse(Console.ReadLine());

            //Console.WriteLine("The prime numbers between " + start + " and " + end + " are:");

            //for (int num = start; num <= end; num++)
            //{
            //    bool isPrime = true;

            //    if (num < 2)
            //    {
            //        isPrime = false;
            //    }
            //    else
            //    {
            //        for (int i = 2; i <= Math.Sqrt(num); i++)
            //        {
            //            if (num % i == 0)
            //            {
            //                isPrime = false;
            //                break;
            //            }
            //        }
            //    }

            //    if (isPrime)
            //    {
            //        Console.Write(num + " ");
            //    }
            //}

            #endregion


            #region 16-  Write a program in C# Sharp to convert a decimal number into binary without using an array. 

            //Console.Write("Enter the number : ");
            //int number = int.Parse(Console.ReadLine());
            //string binary = "";
            //while (number > 0)
            //{
            //    binary = (number % 2) + binary; // Add the remainder to the front of the binary string
            //    number = number / 2; // Divide the number by 2
            //}

            #endregion


            #region 17-  Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            
            //Console.Write("Enter x1: ");
            //double x1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter y1: ");
            //double y1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter x2: ");
            //double x2 = double.Parse(Console.ReadLine());
            //Console.Write("Enter y2: ");
            //double y2 = double.Parse(Console.ReadLine());
            //Console.Write("Enter x3: ");
            //double x3 = double.Parse(Console.ReadLine());
            //Console.Write("Enter y3: ");
            //double y3 = double.Parse(Console.ReadLine());
            //double SL1 = (y2 - y1) / (x2 - x1);
            //double SL2 = (y3 - y2) / (x3 - x2);
            //if (SL1 == SL2)
            //{
            //    Console.WriteLine("The points lie on a single straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points do not lie on a single straight line.");
            //}

            #endregion


            #region 18-  Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows : 
            
            //Console.WriteLine("Enter the time taken to complete the task (in hours): ");
            //int.TryParse(Console.ReadLine(), out int time);
            //switch (time)
            //{
            //    case 2:
            //    case 3:
            //        Console.WriteLine("Highly efficient");
            //        break;
            //    case 4:
            //        Console.WriteLine("Increase speed");
            //        break;
            //    case 5:
            //        Console.WriteLine("Training required to enhance speed");
            //        break;

            //    default:
            //        {
            //            Console.WriteLine("they are required to leave the company.");
            //        }
            //        break;

            #endregion


        }
    }
}

    



