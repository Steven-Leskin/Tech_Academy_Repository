using System;


namespace Functions
{
    class Program
    {


        public static void Welcome(string name)

        {
            Console.WriteLine("Welcome " + name + "!");
        }

        public static void HaveANiceDay(string perjorative)
        {
            Console.WriteLine("Have a nice Day " + perjorative + "!");
        }

        public static void Sum(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        public static void Swap(string x, string y)
        {
            string z;
            z = x;
            x = y;
            y = z;
            Console.WriteLine("x = " + x + "\nand y = " + y);
        }

        public static int Exponent(int x)
        {
            int product = 1;
            for (int i = 0; i < x; i++)
            {
                product = product * x;
            }
            return product;

        }

        public static void PrimeTest(int x)
        {
           Console.WriteLine(((x % 2 == 0) || (x % 3 == 0) || (x % 5 == 0) || (x % 7 == 0) ? x + " is NOT prime." : x+" IS prime."));
        }

        public static void SumDigits(int n)
        { int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine(sum);
        }

        public static void Factorial()
        {
            // given number = 4
            int product;
           {
                product = 4 * 3 * 2 * 1;
                Console.WriteLine(product);
            }
        }


        static void Main(string[] args)
        {
            //Write a program in C# Sharp to create a user define function.

            /*                
            Console.WriteLine("Create a function:");
            Console.WriteLine("___________________________________");
            Welcome();
            HaveANiceDay();
            */

            //Write a program in C# Sharp to create a user define function with parameters.

            /*
            Console.WriteLine("Enter a name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter a perjorative statement, please: ");
            string perjorative = Console.ReadLine();

            Console.WriteLine("Create a function:");
            Console.WriteLine("___________________________________");
            Welcome(name);
            HaveANiceDay(perjorative);
            */


            // Write a program in C# Sharp to create a function for the sum of two numbers. 

            /*
                Console.Write("Enter an integer: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a second integer: ");
                int y = Convert.ToInt32(Console.ReadLine());

                Sum(x, y);
            */

            // Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string.
            // this loops through and counts the space the number of characters as in x.Length. 

            /*
            Console.WriteLine("Enter a string with several words: ");
            string x = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < x.Length; i++)
            {
            if (x.Contains(" ")) { sum++; };        
            }

            Console.WriteLine("The number of spaces is "+sum);
            */

            // Write a program in C# Sharp to calculate the sum of elements in an array. 

            /*
            int[] array = new int[5];

            for (int i = 0; i < array.Length; i++)
            {   
                Console.Write("Enter integer - number {0}: ", i+1);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            for (int j = 0; j < array.Length; j++)
            {
                sum = sum + array[j];
            }
            Console.WriteLine(sum);
            */

            //Write a program in C# Sharp to create a function to swap the values of two integer numbers.

            /*
            Console.WriteLine("input x: ");
            string x= Console.ReadLine();
            Console.WriteLine("input y: ");
            string y = Console.ReadLine();
            Swap(x, y);
            */
            /*
            Swap("Steven", "Leskin");
            */

            //Write a program in C# Sharp to create a function to calculate the result of raising an integer number to another.

            /*
            Console.WriteLine("Enter an integer: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Exponent(x));
            */


            //Write a program in C# Sharp to create a function to check whether a number is prime or not.

            /*
            Console.Write("Enter an integer:");
            int y = Convert.ToInt32(Console.ReadLine());

            PrimeTest(y);
            */


            //Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.

            /*
            Console.WriteLine("Enter a digit with at least three digits: ");
            int n = Convert.ToInt32(Console.ReadLine());

            SumDigits(n);
            */


            //Write a program in C# Sharp to create a recursive function to find the factorial of a given number.
            /*
            Factorial();
            */














        }
    }
}
