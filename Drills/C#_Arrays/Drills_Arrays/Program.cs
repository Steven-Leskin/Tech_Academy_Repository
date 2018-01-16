using System;
using System.Text;
using System.Linq;


namespace Drills_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Write a program in C# Sharp to store elements in an array and print it.
            /*
            int i=0;
            int[] array = new int[10];*/

            //2. Input ten names into array

            /*
            Console.WriteLine("Enter 10 names to become part of the array: ");
            
            string[] names = new string[3];
            Console.WriteLine("INPUT TEN NAMES:");

            for (int i = 0; i <10; i++)
                {
                    Console.Write("Name {0}: ",i+1);
                    names [i] = Console.ReadLine();
                }

            for (int i = 0; i <10; i++)
                {
                Console.WriteLine("Name " + (i+1) + " is {0}", names[i]);
                }
            */

            //2. Write a program in C# Sharp to read n number of values in an array and display it in reverse order.

            /*            
            Console.Write("How many elements will there be in the array?");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] values = new int[n];
            Console.WriteLine("\nInput "+ n + " values- ");

            for (int i = 0; i<n; i++)
            {
                Console.Write("Value of {0} is:",i+1);
                values[i] = Convert.ToInt32(Console.ReadLine());
            }
           
            for (int i=n-1; i>=0; i--)
            {
                Console.WriteLine("{0}",  values[i]);
            }
            */


            //3. Write a program in C# Sharp to find the sum of all elements of the array.

            /*
            int sum=0;
            int[] array = new int[5];
            
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Input five integers: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
               for (int j = 0; j < 5; j++)
            {
                sum = sum+array[j];
            }
            Console.WriteLine(sum);

            */

            //4. Write a program in C# Sharp to copy the elements one array into another array.

            /*
            int[] array1 = new int [5];
            int[] array2 = new int [5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter five integers- integer {0}: ",i+1);
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                array2[i] = array1[i];
                Console.WriteLine(array2[i]);
            }
            */

            //5. Write a program in C# Sharp to count the total number of duplicate elements in an array.

            /*
            int sum = 0;
            int[] array1 = new int[5];
            int[] array2 = new int[5];
            int[] array3 = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter five random integers with at least one duplicate- integer number: {0}: ",i+1);
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                array2[i] = array1[i];
            }

            for (int j = 0; j < 5; j++)
            {
                if (array1[j] != array2[j]) { sum = sum + 1; }
            }

            Console.WriteLine(sum);
            */

            //6.Write a program in C# Sharp to print all unique elements in an array.

            /*
            int[] array1 = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter five integers- integer {0}: ", i + 1);
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(array1);

            for (int i = 0; i < 4; i++)
            {
                if (array1[i] == array1[i + 1]) {Console.WriteLine(""); }

                else

                { Console.WriteLine(array1[i]); }
            }
            */

            //7. Write a program in C# Sharp to merge two arrays of same size sorted in ascending order.
            /*
            int[] array1 = new int [5];
            int[] array2 = new int [5];
            int[] array3 = new int [10]; 

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter a set of five integers- integer {0}: ",i+1);
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter a second set of five integers- integer {0}: ", i + 1);
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Copy(array1, array3, 5);
            Array.Copy(array2, 0, array3, array1.Length, array2.Length);

            Array.Sort(array3);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(array3[i]);
            }
            */


            //8. Write a program in C# Sharp to count the frequency of each element of an array.
            /*
            int[] array1 = { 4, 8, 4, 9, 6, 2 };
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                if (array1[0] == array1[i++]) { sum = sum + 1; }  
                if (array1[1] == array1[i++]) { sum = sum + 1; } 
                if (array1[2] == array1[i++]) { sum = sum + 1; } 
                if (array1[3] == array1[i++]) { sum = sum + 1; }
                if (array1[4] == array1[i++]) { sum = sum + 1; }

            };

            Console.WriteLine(sum);            
            
            */
            
            //9.  Write a program in C# Sharp to find maximum and minimum element in an array.
            //NOTE COMPLETE

            /*int[] array = new int[5];
           
            for (int i = 0; i <= 5; i++)
            {
                Console.Write("Enter five integers: ");
                array[i] = Convert.ToInt32(Console.ReadLine());

            }


            Console.Write("{0}", array[5]);*/




            //10. Write a programin C# Sharp to separate odd and even integers in separate arrays
            //does not work -- sorts on each loop, does not produce a single array.
            /*
            int[] arrayEVEN = new int[12];
            int[] arrayODD = new int[12];
            int[] array = new int[12];
            int j,k,i = 0;

            Console.WriteLine("Enter ten integers. \nSeparate odd and even integers into separate arrays\n**********************************************");

            

                for (j = 0; j < 10; j++)
                {
                    Console.Write("Enter ten integers: {0}: ", j + 1);
                    array[j] = Convert.ToInt32(Console.ReadLine());
                }
    
                for (k = 0; k < 10; k++)
                {
                    if (array[k] % 2 == 0) { arrayEVEN[k] = array[k]; }
                    k++;

                }

                for (i = 0; i < 10; i++)
                {
                    if (array[i] % 2 != 0) { arrayODD[i] = array[i]; }
                    i++;
                }
                Console.WriteLine("The even members of the array are {0}", arrayEVEN[j]);
                Console.WriteLine("The odd members of the array are {0}", arrayODD[j]);
                */


            //11.Write a program in C# Sharp to sort elements of array in ascending order
            /*
            int[] array = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter five integers- integer {0}: ", i + 1);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(array);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(array[i]);
            }
            */

            //12.Write a program in C# Sharp to sort elements of the array in descending order. 
            /*
            int[] array = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter five integers- integer {0}: ", i + 1);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(array);
            for (int i = 4; i >=0; i--)
            {
                Console.WriteLine(array[i]);
            }
            */

            //13Write a program in C# Sharp to insert New value in the array (sorted list ).

            //14. Write a program in C# Sharp to insert New value in the array (unsorted list ).

            //15. Write a program in C#  to delete an element at desired position from an array. 

            //16. Write a program in C# Sharp to find the second largest element in an array
            /*
            int[] array = new int[5];
            
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter five integers- integer {0}: ", i + 1);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(array);
            
                Console.WriteLine("The second largest number in the array is: {0}", array[3]);
            */

            //17. Write a program in C# Sharp to find the second smallest element in an array.

            /*
            int[] array = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter five integers- integer {0}: ", i + 1);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(array);

            Console.WriteLine("The second smallest number in the array is: {0}", array[1]);
            */

            //18. Write a program in C# Sharp for a 2D array of size 3x3 and print the matrix

            //19. Write a program in C# Sharp for addition of two Matrices of same size. 

            //20. Write a program in C# Sharp for subtraction of two Matrices.



        }


    }
}
