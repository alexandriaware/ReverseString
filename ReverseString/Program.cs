using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                Console.WriteLine("Please input a sentence:");
                string forwardString = Console.ReadLine();
                string[] words = forwardString.Split();

                foreach (string word in words.Reverse<string>())
                {
                    Console.WriteLine(word);
                }

                Console.WriteLine("Would you like to play again?");
                answer = Console.ReadLine();
            }

            while (answer == "yes");


            Console.WriteLine("Thanks for playing!");

            
        }
    }
}
