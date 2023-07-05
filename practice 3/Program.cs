using System;
using System.Collections.Generic;
using System.Text;

namespace practice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence1 = " C# is the \"easy\" language "; // back lslashes used to get inverted commas also.
            Console.WriteLine(sentence1);
            string sentence2 = " C# is the \'easy\' language ";
            Console.WriteLine(sentence2);
            string sentence3 = " C# is the \n \"easy\" language "; // will be on new line in output
            Console.WriteLine(sentence3);

            int AslamAge = 23;
            int cnicAge = 18;

            if (AslamAge >= cnicAge)
            {
                Console.WriteLine("You are elgible to vote!");
            }
            else
            {
                Console.WriteLine("You are not elegible to vote cause you are under eighteen");
            }

            int AhmadAge = 17;
            int nicAge = 18;
            if (AhmadAge>= nicAge)
            {
                Console.WriteLine("You are eligible to vote!");
            }
            else
            {
                Console.WriteLine("You are not elegible to vote cause you are under eighteen");
            }
            

            int day = 4;
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
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }

            int[] digits = { 12, 1323, 25, 256 };
            foreach (int i in digits) 
            {
                Console.WriteLine(i);
            }

            string[] fruits = { "mango", "apple", "orange", "watermelon" };
            foreach(string i in fruits)
            {
                Console.WriteLine(i);
            }

          

            int[] array = new int[10];
            array[0] = 12;
            array[1] = 13;
            array[2] = 14;
            array[3] = 15;
            array[4] = 16;
            array[5] = 17;
            array[6] = 18;
            array[7] = 19;
            array[8] = 20;
            array[9] = 21;

            for (int i = 0; i <= 12; i++) //forward loop
            {
                Console.WriteLine(i);
            }
            

            for (int i = 10; i >= 0; --i) // reverse loop 
            {
                Console.WriteLine(i);
            }

            
            Console.ReadLine();

        }


            
        }
        
    }

