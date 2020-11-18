using System;
using System.Linq;

namespace GitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] ArrayOfNumbers = new int[5];
            ArrayOfNumbers[0] = 13;
            ArrayOfNumbers[1] = 22;
            ArrayOfNumbers[2] = 3;
            ArrayOfNumbers[3] = 93;
            ArrayOfNumbers[4] = 1;


            Console.WriteLine("Cehck if you picked a luckynumber ");
            string nr = Console.ReadLine();
            int myNr = Convert.ToInt32(nr);
            */
            /*
            for (int i = 0; i< ArrayOfNumbers.Length; i++)
            {
                if(myNr == ArrayOfNumbers[i])
                {
                    Console.WriteLine("Winner winner chicken dinner");
                    break;
                }
                else
                {
                    Console.WriteLine("Not this time");
                }
            }
            */
            // Console.WriteLine(ArrayOfNumbers.Contains(myNr));

            //övning 2
            //Ett sätt
            //int[] firstOne = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] secondOne = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            //Console.WriteLine(string.Join(',',firstOne));
            //Console.WriteLine(string.Join(',',secondOne));

            //Ett annat sätt
            //Console.WriteLine(string.Join(',',firstOne));
            //Console.WriteLine(string.Join(',',firstOne.Reverse()));

            string[] stringArray = new string[] 
            { "Januari",
                "feb",
                "mars", 
                "april", 
                "maj",
                "juni", 
                "juli", 
                "augusti",
                "september", 
                "oktober", 
                "november", 
                "december"
            };
            string number;
            int choice;

            do
            {
                Console.WriteLine("Select a number from 1-12");
                number = Console.ReadLine();
                choice = Convert.ToInt32(number);
                if (choice<=12)
                {
                    Console.WriteLine(stringArray[choice -1]);
                }

            } while (choice <=12);

                
        }
    }
}
