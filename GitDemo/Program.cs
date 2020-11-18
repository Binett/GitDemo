using System;
using System.Linq;

namespace GitDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] ArrayOfNumbers = new int[5];
            ArrayOfNumbers[0] = 13;
            ArrayOfNumbers[1]= 22;
            ArrayOfNumbers[2] = 3;
            ArrayOfNumbers[3] = 93;
            ArrayOfNumbers[4] = 1;

            
            Console.WriteLine("Cehck if you picked a luckynumber ");
            string nr = Console.ReadLine();
            int myNr = Convert.ToInt32(nr);
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
            Console.WriteLine(ArrayOfNumbers.Contains(myNr));


        }
    }
}
