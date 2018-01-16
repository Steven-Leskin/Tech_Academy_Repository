using System;

namespace DrillSet2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a C# Sharp program that takes three letters as input and display them in reverse order.

                /*
                Console.Write("Enter first letter: ");
                string x = Console.ReadLine();

                Console.Write("Enter second letter: ");
                string y = Console.ReadLine();

                Console.Write("Enter third letter: ");
                string z = Console.ReadLine();

                Console.WriteLine( z+ y+ x);

                 string[] array = {x,y,z};
                 
                Console.WriteLine(array[2]+array[1]+array[0]);
                */


            //Write a C# Sharp program that takes a number and a width also a number, as input and then displays a triangle of that width, using that number.
 
            Console.Write("Enter a letter: ");
            string x = Console.ReadLine();

            Console.Write("Enter a width: ");
             int y  = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < y+1; i++)
            {
                Console.WriteLine
                    (
                    x

                    );

            }

            //Write a C# Sharp program that takes userid and password as input (type string). After 3 wrong attempts, user will be rejected.
            // not complete- is there a way to do this besides as a series of conditional statements?

            //Console.Write("Set userID: ");
            //string setuserID = Console.ReadLine();

            //Console.Write("Set Password: ");
            //string setPassword = Console.ReadLine();

            //Console.Write("Enter userID letter: ");
            //string enterUserId1 = Console.ReadLine();

            //Console.Write("Enter Password: ");
            //string EnterPassword1 = Console.ReadLine();


            //if (setuserID == enterUserId1 && setPassword == EnterPassword1)
            //{ Console.WriteLine("ENTER"); }
            //else

            //{ Console.Write("Enter userID letter: ");
            //    string enterUserId2 = Console.ReadLine();

            //    Console.Write("Enter Password: ");
            //    string EnterPassword2 = Console.ReadLine(); } 

            //    else if (setuserID == enterUserId2 && setPassword == EnterPassword2)
            //        Console.WriteLine("ENTER"); 

            //    else if (setuserID != enterUserId2 && setPassword != EnterPassword2)
            //    { Console.Write("Enter userID letter: ");
            //    string enterUserId3 = Console.ReadLine();

            //    Console.Write("Enter Password: ");
            //    string EnterPassword3 = Console.ReadLine();  

            //    else if (setuserID == enterUserId3 && setPassword == EnterPassword3)
            //        { Console.WriteLine("ENTER"); } 

            //else
            //        { Console.WriteLine("You are locked out."); } 

            //Console.Write("Set userID: ");
            //string setuserID = Console.ReadLine();

            //Console.Write("Set Password: ");
            //string setPassword = Console.ReadLine();

            //Console.Write("Enter userID letter: ");
            //string enterUserId1 = Console.ReadLine();

            //Console.Write("Enter Password: ");
            //string EnterPassword1 = Console.ReadLine();


            //Write a C# Sharp program that takes two numbers as input and perform an operation (+,-,*,x,/) on them and displays the result of that operation.

            //Console.WriteLine("Enter an integer: ");
            //int x = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter a second integer: ");
            //int y = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter an operator: ");
            //int z = Convert.ToInt32(Console.ReadLine());

            //int a=1; 

            //if (z == '+') { a = x + y; }
            //else if (z =='-'){a = (x - y); }
            //else if (z == '*') { a = x * y; }
            //else if (z == '/') { a = x / y; }

            //else { a = 1; };

            //Console.WriteLine((a > 1) ? 0 : z);


            //Write a C# Sharp program that takes the radius of a circle as input and calculate the perimeter and area of the circle.
            //Console.WriteLine("Enter the radius of a circle: ");
            //int r = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine( "circumference equals "+ (2*3.14*r));
            //Console.WriteLine("area equals " +( 3.14*(r*r)));


            // Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1 (using integer numbers for y , ranging from -5 to +5)
            //Console.WriteLine("Enter an integer between -5 and 5: ");
            //int y = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(
            //    ((y < -5) || (y > 5)) ? 0 : ((y * y) + (2 * y) + 1));

            //Write a C# Sharp program that takes distance and time as input and displays the speed in kilometers per hour and miles per hour.
            //Console.Write("Enter time of travel in hours: ");
            //int t = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter distance in miles: ");
            //int d = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter distance in kilometers: ");
            //int kd = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("total speed of travel in mph: " + (d / t));
            //Console.WriteLine("total speed of travel in kph: " + (kd / t));

            //Write a C# Sharp program that takes the radius of a sphere as input and calculate and display the surface and volume of the sphere.
            //Console.Write("Enter radius of sphere: ");
            //int r = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("The surface area of a sphere with a radius of " + r + " is " + (4*(3.14)* r * r) +".");
            //Console.WriteLine("The volume of a sphere with a radius of "+ r + " is "+ (4f/3f)*(3.14)*(r*r*r)+".");



            //Write a C# Sharp program that takes a character as input and check the input (lowercase) is a vowel, a digit, or any other symbol.




            //Write a C# Sharp program that takes two numbers as input and returns true or false when both numbers are even or odd.

            //Console.Write("Enter an integer: ");
            //int x = Convert.ToInt32(Console.ReadLine());           
            //Console.Write("Enter a second integer: ");
            //int y = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(
            //    ((x % 2 == 0) && (y % 2 == 0)) || ((x % 2 != 0) && (y % 2 != 0)) ? "Both numbers are either odd or even" : "One number is even and the other odd");


            //Write a C# Sharp program that takes a decimal number as input and displays its equivalent in binary form.
            Console.Write("Enter an integer: ");
            decimal x = Convert.ToDecimal(Console.ReadLine());    
            




        }
    }
}
