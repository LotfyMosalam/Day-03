using System.Net.NetworkInformation;
using System.Text;
namespace Demo
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main()
        {

            #region Part 01 Control Statments 1. Conditional Statments - If, Switch [Numeric Datatypes]
            /// Example 1 :
            //Console.WriteLine("Please Enter a Month Numbers Existed in 1st Quarter : ");
            //int.TryParse(Console.ReadLine(), out int monthNumber);
            //if (monthNumber == 1)
            //{
            //    Console.WriteLine("Hello January");
            //}
            //else if (monthNumber == 2)
            //{
            //    Console.WriteLine("Hello Febrauary");
            //}
            //else if (monthNumber == 3)
            //{
            //    Console.WriteLine("Hello March");
            //}
            //else
            //{
            //    Console.WriteLine("The Entered Month is not Existed in 1st Quarter");
            //}

            /// Example 2 :
            //Console.WriteLine("Please Enter a Month Numbers Existed in 1st Quarter : ");
            //int.TryParse(Console.ReadLine(), out int monthNumber);
            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Hello January");
            //        break;
            //    case 2:
            //        Console.WriteLine("Hello Febrauary");
            //        break;
            //    case 3:
            //        Console.WriteLine("Hello March");
            //        break;
            //    default:
            //        Console.WriteLine("The Entered Month is not Existed in 1st Quarter");
            //        break;
            //}
            #endregion


            #region Part 02 Switch [Numeric Datatypes (Comparsion Operators)]
            /// Example 1 :

            //Console.WriteLine("Please Enter your Age : ");
            //int.TryParse(Console.ReadLine(), out int Age);
            //if (Age > 22)
            //{
            //    Console.WriteLine("your Age is Greater than 22");
            //}
            //else if (Age < 22)
            //{
            //    Console.WriteLine("your Age is Less than 22");
            //}
            //else
            //{
            //    Console.WriteLine("your Age is equals than 22");
            //}

            /// Example 2 :

            //Console.Write("Please Enter your Age : ");
            //int.TryParse(Console.ReadLine(), out int Age);
            //switch (Age)
            //{
            //    case > 22:
            //        Console.WriteLine("your Age is Greater than 22");
            //        break;
            //    case < 22:
            //        Console.WriteLine("your Age is Less than 22");
            //        break;
            //    default: 
            //        Console.WriteLine("your Age is equals than 22");
            //        break;
            //}

            #endregion


            #region Part 03 Conditional Statments - If, Switch [String Datatype]

            ///// Example 01 :

            //Console.Write("please Enter your Name : ");
            //string Name = Console.ReadLine() ?? "No Name";  

            //if (string.IsNullOrWhiteSpace(Name))
            //{
            //    Name = "No Name";
            //}

            //if (Name == "Lotfy")
            //{
            //    Console.WriteLine("Hello Lotfy");
            //}
            //else if (Name == "Ahmed")
            //{
            //    Console.WriteLine("Hello Ahmed");
            //}
            //else if (Name == "Hend")
            //{
            //    Console.WriteLine("Hello Hend");
            //}
            //else if (Name == "Adel")
            //{
            //    Console.WriteLine("Hello Adel");
            //}
            //else if (Name == "Hanan")
            //{
            //    Console.WriteLine("Hello Hanan");
            //}
            //else
            //{
            //    Console.WriteLine($"Hello {Name}");
            //}

            ///// Example 02 :

            //Console.Write("please Enter your Name : ");
            //string Name = Console.ReadLine() ?? "No Name";

            //if (string.IsNullOrWhiteSpace(Name))
            //{
            //    Name = "No Name";
            //}

            //switch (Name)
            //{
            //    case "Lotfy":
            //        Console.WriteLine("Hello Lotfy");
            //        break;
            //    case "Ahmed":
            //        Console.WriteLine("Hello Ahmed");
            //        break;
            //    case "Farida":
            //        Console.WriteLine("Hello Farida");
            //        break;
            //    default:
            //        Console.WriteLine($"Hello {Name}");
            //        break;
            //}

            //switch (Name)
            //{
            //    case "Nada":
            //        Console.WriteLine("Hello Nada");
            //        break;
            //    case "Nour":
            //        Console.WriteLine("Hello Nour");
            //        break;
            //    case "Alia":
            //        Console.WriteLine("Hello Alia");
            //        break;
            //    case "Selem":
            //        Console.WriteLine("Hello Selem");
            //        break;
            //    case "Ali":
            //        Console.WriteLine("Hello Ali");
            //        break;
            //}
            #endregion


            #region Part 05 Evolution of Switch in C# 7.0

            /// Example 01 :

            //object input = new object();
            //input = 17.5;
            //input = new Person() { Id = 100, Name = "Lotfy" };

            //switch (input)
            //{
            //    case int localInput when localInput > 1:
            //        Console.WriteLine("integer input");
            //        break;
            //    case double localInput:
            //        Console.WriteLine("double input");
            //        break;
            //    case Person person when person.Id == 100:
            //        Console.WriteLine(person.Name);
            //        break;
            //    default:
            //        Console.WriteLine("unknown input");
            //        break;
            //}

            #endregion


            #region Part 05 Switch with goto

            /// Example 01 :

            //Console.Write("Please Enter your Budget : ");
            //int Budget = int.Parse(Console.ReadLine()); 

            //switch (Budget)
            //{
            //    case 3000:
            //        Console.WriteLine("option 3");
            //        goto case 2000;
            //    case 2000:
            //        Console.WriteLine("option 2");
            //        goto case 1000;
            //    case 1000:
            //        Console.WriteLine("option 1");
            //        break;
            //}

            #endregion


            #region Part 06 Evolution of Switch in C# 7.0 (Continued)

            /// Example 01 :

            //Console.Write("please Enter your Age : ");
            //int.TryParse(Console.ReadLine(), out int Age);

            //switch (Age)
            //{
            //    case int when Age > 22 && Age < 100 :  
            //        Console.WriteLine("your Age is Greater than 22");
            //        break;
            //    case < 22:
            //        Console.WriteLine("your Age is less than 22");
            //        break;
            //    default:
            //        Console.WriteLine("your Age equals 22");
            //        break;
            //}

            #endregion


            #region Part 07 Evolution of Switch in C# 8.0

            /// Example 01 :

            //Console.Write("Please Enter an option : ");
            //string option = Console.ReadLine() ?? "0";
            //string Message = string.Empty;

            //switch (option)
            //{
            //    case "1":
            //        Message = "Using Option 1";
            //        break;
            //    case "2":
            //        Message = "Using Option 2";
            //        break;
            //    case "3":
            //        Message = "Using Option 3";
            //        break;
            //    default:
            //        Message = "Unsupported ption";
            //        break;
            //}
            //Console.WriteLine(Message);


            /// Example 02 :

            //Console.Write("Please Enter an option : ");
            //string option = Console.ReadLine() ?? "0";
            //string Message = string.Empty;
            //Message = option switch
            //{
            //    "1" => "Using Option 1",
            //    "2" => "Using Option 2 ",
            //    "3" => "Using Option 3",
            //    _ => "Unsupported option",
            //};
            //Console.WriteLine(Message);


            /// Example 03 :

            //Person person = new Person() { Id = 1, Name = "Lotfy", Age = 26 };
            //switch (person)
            //{
            //    case { Id: 1, Name: "Lotfy", Age: 26 } :
            //        Console.WriteLine("Hello Lotfy, your age is 26");
            //        break;
            //    case { Age: 23 } :
            //            Console.WriteLine("Hello Man => your age is 23");
            //        break;
            //    default:
            //        Console.WriteLine("No matching person found");
            //        break;
            //}

            #endregion


            #region Part 08 Evolution of Switch in C# 9.0

            //Person person = new Person() { Id = 1, Name = "Lotfy", Age = 26 };
            //string Message = "";
            //Message = person switch
            //{
            //    { Id: 1, Name: "Lotfy", Age: 26 } => "Hello Lotfy => your age is 26",
            //    _ => "Unknown Person"
            //};
            //Console.WriteLine(Message);

            #endregion


            #region Part 09 Loop Statements

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion


            #region Part 10 Loop Statements - For, Foreach

            /// Example 01 : 

            //int[] Numbers = { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    if (Numbers[i] == 5)
            //        break;
            //    Console.WriteLine(Numbers[i]);
            //}

            /// Example 02 :

            //int[] Numbers = { 1, 2, 3, 4, 5 };
            //foreach (int number in Numbers)
            //{
            //    Console.WriteLine(number);
            //}

            #endregion


            #region Part 11 Loop Statements - Do While, While

            /// Example 01 :

            //int Number;
            //do
            //{
            //    Console.Write("Please Enter an even number : ");
            //} while (!int.TryParse(Console.ReadLine(), out Number) || Number % 2 == 1);
            //Console.WriteLine($"The even number is : {Number}");


            /// Examble 02

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            #endregion


            #region Part 12 String

            /// Example 01 :

            //string Name;
            //Name = new string("Lotfy");
            //Name = "Lotfy"; // syntax suger
            //Console.WriteLine(Name);
            //Console.WriteLine($"Hashcode ={Name.GetHashCode()}");
            //string Name2 = "Hamada";
            //Console.WriteLine(Name2);
            //Console.WriteLine($"Hashcode ={Name2.GetHashCode()}");

            /// Example 02 :

            //string Name1 = "Lotfy";
            //string Name2 = "Ahmed";
            //Console.WriteLine($"Name1 = {Name1}");
            //Console.WriteLine($"Hashcode = {Name1.GetHashCode()}");
            //Console.WriteLine($"Name2 = {Name2}");
            //Console.WriteLine($"Hashcode = {Name2.GetHashCode()}");
            //Console.WriteLine("------------------------------------");
            //Name2 = Name1;
            //Console.WriteLine($"Name1 = {Name1}");
            //Console.WriteLine($"Hashcode = {Name1.GetHashCode()}");
            //Console.WriteLine($"Name2 = {Name2}");
            //Console.WriteLine($"Hashcode = {Name2.GetHashCode()}");

            /// Example 03 :

            //string Name1 = "Lotfy";
            //string Name2 = "Ahmed";
            //Console.WriteLine(Name1);
            //Console.WriteLine(Name2);
            //Console.WriteLine("********");
            //Name2 = Name1;
            //Console.WriteLine(Name1);
            //Console.WriteLine(Name2);
            //Console.WriteLine("********");
            //Name1 = "Hend";
            //Console.WriteLine(Name1);
            //Console.WriteLine(Name2);

            #endregion


            #region Part 13 StringBuilder

            /// Example 01 :

            //StringBuilder Message;
            //Message = new StringBuilder("Hello");
            //Console.WriteLine($"Message : {Message}");
            //Console.WriteLine($"Message Hashcode is : {Message.GetHashCode()}");
            //Console.WriteLine("**********************************");
            //Message.Append(" Lotfy");
            //Console.WriteLine($"Message : {Message}");
            //Console.WriteLine($"Message Hashcode is : {Message.GetHashCode()}");


            /// Example 02 :

            //StringBuilder Message;
            //Message = new StringBuilder("Hello");
            //Console.WriteLine(Message);
            //Console.WriteLine($"Message Hashcode : {Message.GetHashCode()}");
            //Message.Append(" Lotfy");
            //Console.WriteLine(Message);
            //Console.WriteLine($"Message Hashcode : {Message.GetHashCode()}");


            /// Example 03 :

            //StringBuilder Message;
            //Message = new StringBuilder("Hello");
            //Message.Append(" Lotfy");
            //Message.AppendLine(" Mosalam");
            //Message.AppendLine("Your age is 26");
            //Message.Remove(0, 5);
            //Message.Insert(0, "Hi");
            ////Message.Clear();
            ////Message.AppendFormat("{0} : {1}", true, 'A');
            ////Message.AppendJoin(" => ", "Real", "Madrid");

            //Console.WriteLine(Message);
            
            #endregion


        }
    }
}
