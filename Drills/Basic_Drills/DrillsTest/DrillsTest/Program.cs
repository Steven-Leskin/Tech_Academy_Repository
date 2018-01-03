using System;
using System.Collections.Generic;


namespace DrillsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int number1, number2,number3,number4;

            Console.Write("\nenter first number: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("\nenter second number: ");
            number2 = int.Parse(Console.ReadLine());
            Console.Write("\nenter third number: ");
            number3 = int.Parse(Console.ReadLine());
            Console.Write("\nenter fourth number: ");
            number4 = int.Parse(Console.ReadLine());
            Console.WriteLine((number1+number2)*number3);
            Console.WriteLine((number1*number2)+(number2*number3));
            */

            /*
            int age;
            Console.Write("Enter your age: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("\nHey! You look pretty good for " + age + ".");
            */

            /*
            int x;
            Console.Write("Pick a number:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("\n"+x+" " +x+" " +x+" " +x+" " +"\n"+x+x+x+x+"\n"+x+" "+ x+" "+ x+" " +x+"\n"+x+x+x+x);
            */

            /*
            int x,y;
            Console.Write("Pick a number:");
            x = int.Parse(Console.ReadLine());
            Console.Write("Pick another number: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} {1} {0} {1} "+"\n"+"{0}{1}{0}{1}"+"\n"+ "{0} {1} {0} {1}"+"\n"+"{0}{1}{0}{1}", x,y);
            */

            /*
            int x,y,n;
            Console.Write("Pick a number:");
            x = int.Parse(Console.ReadLine());
            Console.Write("Pick another number: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Pick your favorite iteration number: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0} {1} {0} {1}",x,y );
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}{1}{0}{1}", x, y);
            }
            */

            /*
            int x;
            Console.Write("Pick a number:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine
               ("\n"+  x + x + x + 
                "\n" + x + x + x +
                "\n" + x + x + x +
                "\n" + x + x + x +
                "\n" + x + x + x);
            */

            /*
            double enteredNr = 8;
            int firstRow = 1;
            int lastRow = 5;

            for (int i = firstRow; i <= lastRow; i++)
            Console.WriteLine($"{enteredNr}{(firstRow == i || lastRow == i ? enteredNr.ToString() : " ")}{enteredNr}");
            */

            /*
            double cel,kel,far;
            Console.Write("Enter degrees celsius:");
            cel = int.Parse(Console.ReadLine());
            far =(cel * 1.8) + 32;
            kel = cel+273.15;

            Console.WriteLine("The temperature in kelvin is: "+kel);
            Console.WriteLine("The temperature in farenheit is: "+ far);
            */

            /*
            Console.Write("Enter word here: "); 
            string word = Console.ReadLine();
            char firstLetter = word[0];
            int temp = word.Length - 1;
            char lastLetter = word[temp];
            string newWord = word.Replace(firstLetter, lastLetter);
            string newWord2 =newWord.Replace(lastLetter,firstLetter);
            Console.WriteLine(newWord);
            //note code does not work- replaces one but not both in succession.
            */

            /*
            Console.Write("Enter a string here: "); 
            string word = Console.ReadLine();
            char firstLetter = word[0];
            Console.WriteLine(firstLetter + word + firstLetter);
            */

            /*
            Console.WriteLine("Is one of the numbers negative?\n");
            Console.Write("Enter first integer here: "); 
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer here: ");
            int y = int.Parse(Console.ReadLine());

            bool xResult;
            bool yResult;

            xResult=  bool.Parse((x > 0) ?  "true" : "false");

            yResult= bool.Parse((y<0) ? "true" : "false");

            if (xResult ^ !yResult == true || !xResult ^yResult==true)
               Console.WriteLine("The result is true");
            else
                Console.WriteLine("The result is false");

                //Console.WriteLine((x > 0 && y < 0) || (x < 0 && y > 0));

            //last line of code was given answer- my six lines reduced to one. Another good answer was to multiply x*y-if result is negative, then true.

            */

            /*
            Console.Write("Enter first integer here: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer here: ");
            int y = int.Parse(Console.ReadLine());

            int result = x * y;
            if (x == y)
            Console.WriteLine(result * 3);
            else
            Console.WriteLine(result);

            Console.WriteLine((x==y? (x+y)*3 : x+y));
            */

            /*
            Console.Write("Enter first integer here: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer here: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine(x > y ? (Math.Abs(x - y * 2 )) : Math.Abs(x - y))           
            */

            /*
            Console.Write("Enter first integer here: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer here: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Let's see if we can get to 20?");

            if (x == 20 || y == 20)
            { Console.WriteLine("Yahoo! It's 20."); }
            else if (x + y == 20)
            { Console.WriteLine("Yahoo! It's 20."); }
             else
            { Console.WriteLine("We aint going to make it"); }
            */

            /* 
             Console.Write("Enter first integer here: ");
             int x = int.Parse(Console.ReadLine());

             Console.Write("Enter second integer here: ");
             int y = int.Parse(Console.ReadLine());

             if ((x < 120 && x > 80) || (x == 200))
             { Console.WriteLine("true"); }
             else
             { Console.WriteLine("false"); }

             Console.WriteLine(((x < 120 && x > 80) || (x == 200)));
             */

            /*
            Console.Write("Enter integer here: ");
            string x = Console.ReadLine();
            for (int i = 1; i < 101; i+=2)
            {
            Console.WriteLine(i);
            };
            */


            // reverse the words of a sentence
            /*
            Console.Write("Enter sentence here: ");
            string x = Console.ReadLine();
            string[] myArray = x.Split();
            Array.Reverse(myArray);
            Console.WriteLine(String.Join(" ", myArray));
            */

            /*
            //Given solution did not work
            Console.Write("Enter sentence here: ");
            string x = Console.ReadLine();
            Console.WriteLine("\nDisplay the original sentence: " + x);
            string line = x;
            string result = " ";
            List<string> wordslist = new List<string>();
            string[] words = line.Split(
                new[] { "" }, StringSplitOptions.None);
            for (int i = words.Length - 1; i >= 0; i--)
            {
                result += words[i] + " ";
            }
            wordslist.Add(result);
            foreach (String s in wordslist)
            { Console.WriteLine(s); }
            */

            //####### file size in bytes

            /*
            Console.Write("Enter file path: ");
            string path = Console.ReadLine();
            long length = new System.IO.FileInfo(path).Length;
            Console.WriteLine(length)
                */

            //############Convert Hexadecimal to decimal
            //this does not work.See http://www.permadi.com/tutorial/numHexToDec/ to convert hex to dec.
            //this was supposed to work by multiplying hex values by 16 and power incremented by 1

            /*
        Console.Write("Enter hexadecimal: ");
        string hexadecimal = Console.ReadLine();
        int sum;
        int newSum = 0;
        string[] hexadecimalArray = hexadecimal.Split(' ');

        for (int i = 0; i < hexadecimalArray.Length; i++)
        {
            sum = Convert.ToInt32(hexadecimalArray[i]) * (16 ^ i);
            newSum = newSum + sum;
        }

        Console.WriteLine(newSum);

        from solution-not using System solution
        Console.Write("Enter hexadecimal: ");
        string hexadecimal = Console.ReadLine();
        int hexadecimalINT = Convert.ToInt32(hexadecimal);
        hexadecimal = int.Parse(hexadecimal, System.Globalization.NumberStyles.HexNumber).ToString();
        Console.WriteLine(hexadecimal);
        */


            //multiply correspondening elements from two arrays- this multiplies one element
            /*
            int[] arrayOne = new int[3] { 3, 6, 9 };
            int[] arrayTwo = new int[3] { 2, 4, 6 };

            for (int i = 0; i < 3; i++)
            {
                int x = arrayOne[i];
                int y = arrayTwo[i];
                Console.WriteLine(x * y);
            }
            */

            /*
            Console.Write("Enter sentence here: ");
            string x = Console.ReadLine();
            Console.Write("Enter sentence here: ");
            string x = Console.ReadLine();

            go to the last string in a sentence. If the last element is less than four, return that element four times.If four or more, do nothing.

           not completed - instructions not clear-results different from solution to different users.
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            string[] sentenceArray = sentence.Split(',');
            int x = sentenceArray.Length;
            string y = sentence.Substring(x);
            Console.WriteLine(x);
            */


            //check if a given positive number is a multiple of 3 or a multiple of 7.
            /*
            Console.Write("Enter an integer: ");
            string number = Console.ReadLine();
            int numberINT = Convert.ToInt32(number);
            if (numberINT % 7 == 0 || numberINT % 3 == 0)
            { Console.WriteLine("Interger is divisible by 7 or 3"); }
            else
            { Console.WriteLine("Integer is not divisible by 7 or 3"); };
            */

            //Write a C# program to check if a string starts with a specified word.
            /*
            Console.Write("Enter a sentence: ");
            string word = Console.ReadLine();
            Console.Write("Enter a word: ");
            string sentence = Console.ReadLine();
            Console.WriteLine(sentence.StartsWith(word) ? "The second word started the sentence." : "The second entered word does not begin the sentence.");
            */

            //Write a C# program to check if parameters entered are less than 100 and greater than 200.
            /*
            Console.Write("Enter a number less than 100: ");
            string x = Console.ReadLine();
            Console.Write("Enter a number greater than 200: ");
            string y = Console.ReadLine();
            int xINT = Convert.ToInt32(x);
            int yINT = Convert.ToInt32(y);
            Console.WriteLine("Let's see if you followed the instructions?");
            Console.WriteLine(xINT < 100 && yINT > 200);
            */

            //Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10
            /*
            Console.Write("Enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x > -10 && x < 10);
            */


            //Write a C# program to check if "HP" appears at second position in a string and returns the string without "HP"
            /*
            Console.Write("Enter a sentence: ");
             string sentence = Console.ReadLine();
            { Console.WriteLine(sentence.IndexOf("HP") == 1 ? sentence.Replace("HP", " ") : sentence ); };
            */

            //Write a C# program to find the largest and lowest values from three integer values//Console.Write("Enter a number less than 100: ");
            //this was more difficult than I thought. Using <> was hard becasue of converting bool to int in conditional statements. Creating a sort array did not work.

            /*
            Console.Write("Enter an integer ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a second integer: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a  third integer: ");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Max(x, Math.Max(y, z)));
            Console.WriteLine(Math.Min(x, Math.Min(y, z)));
            below did not work:
            if ((x > z) || (y > z)) { Console.WriteLine(z); }
            else if
               ((y > x) || (z > x)) { Console.WriteLine(x); }
            else if
                 ((z > y) || (x > y)) { Console.WriteLine(y); }
            else { Console.WriteLine("You are so screwed."); };
            */

            //Write a C# program to check the nearest value of 20 of two given integers and return 0 if two numbers are same. Go to the editor
            //modified to include situation where the numbers are not equal but equidistant from 20.

            /*
            Console.Write("Enter an integer ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a second integer: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int a = Math.Abs(x - 20);
            int b = Math.Abs(y - 20);
            if ((x == y) || (a == b)) { Console.WriteLine("The two numbers are equal"); }
            else
                Console.WriteLine((a > b ? x : y));
            */


            //Write a C# program to check if a given string starts with "w" and immediately followed by two "ww"
            //question requires two "ww"- not sure why answer is more complicated than below.

            /*
            Console.Write("Enter three random letters:");
            string letters = (Console.ReadLine());
            Console.WriteLine(letters == "www" ? "true" : "false");
            */

            //Write a C# program to create a new string which deletes every other character (odd position) from the first position of a given string. 
            /*
            Console.Write("Enter a word: ");
            string word = (Console.ReadLine());

            for (int i = 0; i <= word.Length - 2; i += 2)
            {
                Console.WriteLine(word.Substring(i, 1));
            }
            */


            // Write a C# program to check if a number appears as either the first or last element of an array of integers and the length is 1 or more.
            /*
            Console.Write("Enter first number:");
            int firstInteger = Convert.ToInt32((Console.ReadLine()));
            Console.Write("Enter second number:");
            int secondInteger = Convert.ToInt32((Console.ReadLine()));
            int[] array = { 1, 2, 3, 4 };
            int newfirstInteger = array[0];
            int newsecondInteger = array[3];
            Console.WriteLine((firstInteger == newfirstInteger && newfirstInteger > 0) ? "true" : "false");
            Console.WriteLine((secondInteger == newsecondInteger && newsecondInteger > 0) ? "true" : "false");
            */


            // Write a C# program to compute the sum of all the elements of an array of integers

            /*
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }

            Console.WriteLine(sum);
            */


            //Write a C# program to check if the first element and the last element are equal of an array of integers and the length is 1 or more.

            /*
            int[] array = { 1, 3, 5, 6, 8, 2 };
            Console.WriteLine(array[0]==array[5]?"true":"false");
            */

            //Write a C# program to check if the first element or the last element of the two arrays ( length 1 or more) are equal.

            /*
            int[] firstArray = { 1, 2, 3, 4, 5, 6, 6 };
            int[] secondArray = { 7, 6, 5, 4, 3, 2, 7 };
            Console.WriteLine(
                (firstArray[0] == secondArray[0] || firstArray[6] == secondArray[6] ? "true" : "false")
                );
            */

            // Write a C# program to rotate an array (length 3) of integers in left direction.

            /*
            int[] array = { 1, 2, 3 };
            Console.WriteLine(array[1].ToString()+array[2].ToString()+array[0].ToString());
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(i < array.Length - 1 ? array[i + 1] : array[0]);
            }
            */

            //Write a C# program to check if an array contains an odd number.
            /*
            int[] array = { 2, 4, 6, 8, 10, 11 };

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                { Console.WriteLine("true"); break; }

            };

            Console.WriteLine((array[i] % 2 == 0) ? "true" : "false");
            */


















        }

    }
}
