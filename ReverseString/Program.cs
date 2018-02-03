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
            string forwardString = "Hello world!";
            string[] words = forwardString.Split();
            
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }


        }
    }
}
