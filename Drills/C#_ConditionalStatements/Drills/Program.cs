using System;

namespace Drills
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fizz Buzz

            /*for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0) Console.Write("fizz \n");
                if (i % 5 == 0) Console.Write("buzz  \n");
                if ((i % 3 == 0) && (i % 5 == 0)) Console.Write("FIZZBUZZ \n");
            }*/

            //Write a C# Sharp program to accept two integers and check whether they are equal or not."

            /*
            Console.Write("Enter the first of two integers: ");
            int x=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second of two integers: ");
            int y =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((x==y)? "The numbers are equal.": "The numbers are not equal.");
            */


            // Write a C# Sharp program to check whether a given number is even or odd

            /*
            Console.Write("Enter an integer: ");
            int x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((x %2 ==0)? "The number is even": "The number is odd");
            */


            //a C# Sharp program to check whether a given number is positive or negative. 

            /*
            Console.Write("Enter an integer: ");
            int x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((x %2 ==0)? "The number is even": "The number is odd");
            */

            // C# Sharp program to find whether a given year is a leap year or not.

            /*
            Console.Write("Enter a year: ");
            int x=Convert.ToInt32(Console.ReadLine());
            if (x % 4 == 0) { Console.WriteLine(x + " is a leap year."); }
            else if (x % 100 != 0) { Console.WriteLine(x + " is not a leap year."); }
            else if (x % 400 != 0) { Console.WriteLine(x + " is not a leap year."); }
            else
            Console.WriteLine(x + " is a leap year.");   
            */

            //alternative solution using method
            /*
            Console.Write("Enter a year: ");
            int x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DateTime.IsLeapYear(x) ? "true":"false");
            */


            //a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote. 

            /*
            Console.Write("Enter candidate's name: ");
            string x = Console.ReadLine();
            Console.Write("Enter candidates year of birth: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((DateTime.Now.Year - y > 18) ? (x + " is elegible to vote") : (x + " is not elegible to vote"));
            */

            //Write a program to determine if job applicant is tall enough for job in centimeters

            /*
            Console.Write("Enter height in centimeters: ");
            int ht = Convert.ToInt32(Console.ReadLine());
            if (ht < 100) Console.WriteLine("Applicant is too short for the job--Ha Ha Ha");
            else if (ht > 101 && ht < 150) Console.WriteLine("Applicant will need to sit on a booster seat");
            else if (ht > 151 && ht < 200) Console.WriteLine("Applicant will require a chair");
            else if (ht > 201) Console.WriteLine("Applicant will qualify for the job");
            else Console.WriteLine("Applicant will get the job automatically");
            */

           
            //Write a C# Sharp program to find the largest of three numbers. 
            /*
            Console.Write("Enter an integer: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a second integer: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a third integer: ");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((x > y) ? x : (x > z) ? x : (y > z) ? y : (y > x) ? y : (z > y)? z:(z>x)?z:z);                ;
            */
            
            //*Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
            /*
            Console.Write("Enter a positive number betwen 11 and 20 for the x axis: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a positive number between 1 and 10 for the y axis: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if ((x >= 11 && x <= 15) && (y >= 1 && y <= 5)) Console.WriteLine("bottom, left");
            else if ((x >= 11 && x <= 15) && (y >= 6 && y <= 10)) Console.WriteLine("top, left");
            else if ((x >= 16 && x <= 20) && (y >= 1 && y <= 5)) Console.WriteLine("bottom, right");
            else if ((x >= 16 && x <= 20) && (y >= 6 && y <= 10)) Console.WriteLine("top, right");
            else if ((y >= 1 && x <= 5) && (x >= 11 && y <= 15)) Console.WriteLine("right, bottom");
            else if ((y >= 1 && x <= 5) && (x >= 16 && y <= 20)) Console.WriteLine("left, bottom");
            else if ((y >= 6 && x <= 10) && (x >= 11 && y <= 15)) Console.WriteLine("left, top");
            else if ((y >= 6 && x <= 10) && (x >= 16 && y <= 20)) Console.WriteLine("left, top");
            */

            //Write a C# Sharp program to find the eligibility of admission for a professional course based on the following criteria: 

            /*Console.Write("Enter math score: ");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter physics score: ");
            int physics = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter chemistry score: ");
            int chemistry = Convert.ToInt32(Console.ReadLine());
            int totalScore = (math + physics + chemistry);
            int mathPhysicsScore = (math + physics);
            Console.WriteLine(
                (((math >= 65) && (physics >= 55) && (chemistry >= 50) || 
                (totalScore >= 180)) 
                || (mathPhysicsScore >= 140)) ? 
                "Student is eligible" : "Student is not eligible");
            */

            /*Write a C# Sharp program to read temperature in centigrade and display a suitable message according to temperature state below
            Temp< 0 then Freezing weather
            Temp 0 - 10 then Very Cold weather
            Temp 10 - 20 then Cold weather
            Temp 20 - 30 then Normal in Temp
            Temp 30 - 40 then Its Hot
            Temp >= 40 then Its Very Hot*/

            /*Console.Write("Enter outside temperature in centigrade: ");
            int temp = Convert.ToInt32(Console.ReadLine());
            if (temp < 0) Console.WriteLine("Freezing Weather");
            else if (temp>0 && temp<10) Console.WriteLine("Very Cold Weather");
            else if (temp > 11 && temp < 20) Console.WriteLine("Cold Weather");
            else if (temp > 21 && temp < 30) Console.WriteLine("Normal Weather");
            else if (temp > 31 && temp < 40) Console.WriteLine("Hot Weather");
            else if (temp > 40) Console.WriteLine("Very Hot Weather");*/

            /*Console.Write("Enter : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter physics score: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter chemistry score: ");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter chemistry score: ");



            /*Test Data : 
                50 50 60
                Expected Output :
                This is an isosceles triangle.*/

            /*Write a C# Sharp program to check whether a triangle can be formed by the given value for the angles.*/
            /*Console.Write("Enter an angle: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a second angle: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a third angle: ");
            int z = Convert.ToInt32(Console.ReadLine());
 
            // Write a C# Sharp program to check whether an alphabet is a vowel or consonant. */
            /*Console.Write("Enter a letter: ");
            string x=Console.ReadLine();
            Console.WriteLine(((x=="a" )||( x=="e") || (x=="i") || (x=="o") || (x=="u")) ? "Input is a vowel." : "Input is NOT a vowel.");*/

            /* Write a C# Sharp program to calculate profit and loss on a transaction. */
            /*Console.Write("What are the cost to produce a product: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("How much does the product sell for: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x>y? "the product cost more to produce than sell": "You'll make money on this winner");*/

            /* Write a program in C# Sharp to read any day number in integer and display day name in the word */
            // example uses a switch

            /*Console.Write("Enter number from 1 to 7 for day of week: ");
            int day = Convert.ToInt32(Console.ReadLine());
            
            switch (day)

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

                default:
                    Console.WriteLine("Sunday");
                    break;
                    
             }*/

            //Write a program in C# Sharp to read any Month Number and return the name of the month.
            /*
            Console.Write("Enter a number for a month: ");
            int Month = Convert.ToInt32(Console.ReadLine());
            switch (Month)

            {
                case 1:
                    Console.WriteLine("January");
                    break;

                case 2:
                    Console.WriteLine("February");
                    break;

                case 3:
                    Console.WriteLine("March");
                    break;

                case 4:
                    Console.WriteLine("April");
                    break;

                case 5:
                    Console.WriteLine("May");
                    break;

                case 6:
                    Console.WriteLine("June");
                    break;

                case 7:
                    Console.WriteLine("July");
                    break;

                case 8:
                    Console.WriteLine("August");
                    break;

                case 9:
                    Console.WriteLine("September");
                    break;

                case 10:
                    Console.WriteLine("October");
                    break;

                case 11:
                    Console.WriteLine("November");
                    break;

                case 12:
                    Console.WriteLine("December");
                    break;

                default:
                   Console.WriteLine("Invalid Entry");
                    break;
            } */

            /*
            Console.Write("Enter a number for a month: ");
            int Month = Convert.ToInt32(Console.Read());
            switch (Month)

            {
                case 1:
                    Console.WriteLine("January");
                    break;

                case 2:
                    Console.WriteLine("February");
                    break;

                case 3:
                    Console.WriteLine("March");
                    break;

                case 4:
                    Console.WriteLine("April");
                    break;

                case 5:
                    Console.WriteLine("May");
                    break;

                case 6:
                    Console.WriteLine("June");
                    break;

                case 7:
                    Console.WriteLine("July");
                    break;

                case 8:
                    Console.WriteLine("August");
                    break;

                case 9:
                    Console.WriteLine("September");
                    break;

                case 10:
                    Console.WriteLine("October");
                    break;

                case 11:
                    Console.WriteLine("November");
                    break;

                case 12:
                    Console.WriteLine("December");
                    break;

                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            
            }
            */

            /*Console.Write("Enter the name of a month: ");
            string Month = Console.ReadLine();

            switch (Month)

            {
                case "January":
                    Console.WriteLine("31");
                    break;

                case "February":
                    Console.WriteLine("28");
                    break;

                case "March":
                    Console.WriteLine("30");
                    break;

                case "April":
                    Console.WriteLine("30");
                    break;

                case "May":
                    Console.WriteLine("30");
                    break;

                case "June":
                    Console.WriteLine("30");
                    break;

                case "July":
                    Console.WriteLine("31");
                    break;

                case "August":
                    Console.WriteLine("31");
                    break;

                case "September":
                    Console.WriteLine("31");
                    break;

                case "October":
                    Console.WriteLine("31");
                    break;

                case "November":
                    Console.WriteLine("31");
                    break;

                case "December":
                    Console.WriteLine("31");
                    break;

                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }*/



            //  Enter a month, return the number of days in the month.

            /*Console.Write("Enter a number for a month: ");
            int Month = Convert.ToInt32(Console.Read());
            switch (Month)

            {
                case 1:
                    Console.WriteLine("January");
                    break;

                case 2:
                    Console.WriteLine("February");
                    break;

                case 3:
                    Console.WriteLine("March");
                    break;

                case 4:
                    Console.WriteLine("April");
                    break;

                case 5:
                    Console.WriteLine("May");
                    break;

                case 6:
                    Console.WriteLine("June");
                    break;

                case 7:
                    Console.WriteLine("July");
                    break;

                case 8:
                    Console.WriteLine("August");
                    break;

                case 9:
                    Console.WriteLine("September");
                    break;

                case 10:
                    Console.WriteLine("October");
                    break;

                case 11:
                    Console.WriteLine("November");
                    break;

                case 12:
                    Console.WriteLine("December");
                    break;

                default:
                    Console.WriteLine("Invalid Entry");
                    break;
              }*/

            //Write a program in C# Sharp which is a Menu-Driven Program to compute the area of the various geometrical shape.
            /*Console.Write("To find the area of a square, enter 1 \n" +
                "To find the area of a rectangle, enter 2 \n" +
                "To find the area of a circle, enter 3 \n"+
                "______________________________________ \n");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 1)
            {
                Console.WriteLine("___________________________________\n" +
                    "Enter length of one side of sqare: ");
                int sqr = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("___________________________________\n" +
                    "The area of the square is " + (sqr * sqr) + ".");
            }
            else if (x == 2)
            {
                Console.WriteLine("___________________________________\n" +
                "Enter one length of one side of a rectangle: ");
                int rec1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter length of second side of a rectangle: ");
                int rec2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("___________________________________\n" + 
                    "The area of the square is " + (rec1 * rec2) + ".");
            }
            else if (x == 3)
            {
                Console.WriteLine("___________________________________\n" +
                "Enter the radius of a circle: ");
                int radius = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("___________________________________\n" + 
                    "The area of the circle is " + ((radius*radius)*3.14) + ".");
            }*/

            //Write a program in C# Sharp which is a Menu-Driven Program to perform a simple calculation.

            /*Console.WriteLine("Enter a selection:\n\n");
            Console.WriteLine("For addition, 1 \n" + "For subtraction, 2\n" + "For multiplication, 3\n" + "For division, 4\n" + "Exit, 5");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an integer: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an integer: ");
            int z = Convert.ToInt32(Console.ReadLine());
            int total=0;

            switch (x)
            {
                case 1:
                    total = y + z;
                    break;

                case 2:
                    total = y - z;
                    break;

                case 3:
                    total = y * z;
                    break;

                case 4:
                    total = y / z;
                    break;

                default:

                    break;                           
            }
            Console.WriteLine("The total is:  {0}", total);*/

        }
    }
}
