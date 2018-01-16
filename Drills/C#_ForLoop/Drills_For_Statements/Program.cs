using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drills_For_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program in C# Sharp to display the first 10 natural numbers.
            /*for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }*/

            //Write a C# Sharp program to find the sum of first 10 natural numbers. 

            /*
            int sum=0; 
            for (int i = 1; i <= 10; i++)
            {                
                sum = sum + i;
            }
            Console.WriteLine(sum);
            */

            //Write a program in C# Sharp to display n terms of natural number and their sum

            /*
            Console.Write("Enter an integer: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(sum = sum + i);
            }
            */


            //Write a program in C# Sharp to read 5 numbers from keyboard and find their sum and average

            /*
            Console.Write("Enter an integer: ");
            int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter an integer: ");
                int b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter an integer: ");
                    int c = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter an integer: ");
                        int d = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter an integer: ");
                    int e = Convert.ToInt32(Console.ReadLine());
                int sum = a + b + c + d + e;
                int average = (sum / 5);
            Console.WriteLine("The sum of the inputed integers is {0}"
                +"\nThe average of the inputed integers is {1}",sum, average);
            */
            // from solution. My answer was above. Below answer loops ReadLine to input data.

            /*
            int i, n, sum = 0;
            double avg;
            Console.Write("Input the 10 numbers : \n");
            for (i = 1; i <= 10; i++)
            {
                Console.Write("Number-{0} :", i);

                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }
            avg = sum / 10.0;
            Console.Write("The sum of 10 no is : {0}\nThe Average is : {1}\n", sum, avg);
        }*/

            //Write a program in C# Sharp to display the cube of the number upto given an integer

            /*
            Console.Write("Enter an integer: ");
            int y = Convert.ToInt32(Console.ReadLine());
             for (int i = 1; i <= y; i++)
            {
                Console.WriteLine("\nThe number is " + i + " and the cube of " + i + " is "+(i * i * i));
            }
              */


            //Write a program in C# Sharp to display the multiplication table of a given integer
            /*
            Console.Write("Enter an integer: ");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <=a; i++)
            {
                Console.WriteLine(i+" times "+a + " equals :"+(i*a));
            }
            */

            //Write a program in C# Sharp to display the multiplication table vertically from 1 to n
            /*
            Console.Write("Enter an integer: ");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= a; i++)
            {
                for (int j = 0; j <=a; j++)
                {
                    Console.WriteLine(j + " x " + a + " = " + (j * a));
                };
            }
            */

            //Write a program in C# Sharp to display the n terms of odd natural number and their sum.
            /*
            Console.Write("Enter an integer: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i <=(2*x); i++)
            {
                if (i % 2 != 0)
                {
                sum=sum + i;
                Console.WriteLine(i);
                }
            }
            Console.WriteLine("\nThe sume equals {0}",sum);
            */

            //Write a program in C# Sharp to display the pattern like right angle triangle using an asterisk

            /*
            Console.Write("Enter an integer: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            string a = "*";
            Console.WriteLine("*");
            for (int i = 1; i <= rows; i++)
            {
                Console.WriteLine(a=a+"*");                
            }
            */

            //Write a program in C# Sharp to display the pattern like right angle triangle with a number

            /*
            int i, j, rows;
            Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0}", j);
                Console.Write("\n");
            }*/

            //Write a program in C# Sharp to make such a pattern like right angle triangle with a number which will repeat a number in a row.
            //Note: second, inner  for loop does not need brackets, and the brackets affected formatting. With second brackets, results were linear. Without brackets, results returned in a line.
            /*
            Console.Write("Enter number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int columns = 1; columns <= rows; columns++)
            {
                for (int J = 0; J < columns; J++)
                    Console.Write("{0}", columns);
                Console.Write("\n");
            }
            */

            //Write a program in C# Sharp to make such a pattern like right angle triangle with number increased by 1
            /*
            Console.Write("Enter number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
             
            for (int columns = 1; columns <= rows; columns++)
            {
                for (int J = 0; J < columns; J++)
                    if (columns == 1)
                    {
                        Console.Write(columns);
                    }
                    else
                        Console.Write(columns + 1);
                Console.Write("\n");
            }
            */


            //Write a C# Sharp program to calculate the factorial of a given number, eg, 4 X 3 X 2 X 1

            /*
            Console.Write("Enter an integer: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int product=1; 
                for (int i = 1; i <= x; i++)
            {
                product = product*i;
            }

            Console.WriteLine(product);
            */


            // Write a program in C# Sharp to display the n terms of even natural number and their sum
            /*
            int product=0;
            Console.Write("Enter an integer: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= (n*2); i++)
            {
                if (i % 2 == 0)

                {
                    product = product + i;
                }
                    
            }
            Console.WriteLine(product);
            */

            /*
            //Write a program in C# Sharp to display the n terms of harmonic series and their sum. 
            int sum=10;
            Console.WriteLine("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                sum=+ 1 (sum +(1 / i));        
            }
            */

            //21. Write a program in C# Sharp to display the sum of the series [ 9 + 99 + 999 + 9999 ...].
            //NOT DONE...does not add a digit on each iteration of the loop.
            
            /*
            int x=9;
            int sum;
            Console.Write("Enter an integer: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= n+1; i++)
            {
                
            }
            Console.WriteLine(sum);
            */

        }
    }
}
