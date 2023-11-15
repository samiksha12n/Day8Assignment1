using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day8AssignmentRegExpression
{
    internal class Program
    {
        static int searchfor(string input, string pattern)
        {
            Regex reg = new Regex(pattern);
            int count = reg.Matches(input).Count;
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text/sentence/paragraph");
            string input = Console.ReadLine();

            Console.WriteLine("Number of world present in the sentence");
            int count = 1;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";
            int noofemai = searchfor(input, pattern);
            Console.WriteLine("Number of email in given text is " + noofemai);

            string pattern2 = @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";
            int noOfPhone = searchfor(input, pattern2);
            Console.WriteLine("Number of phone number in given text " + noOfPhone);



            Console.ReadKey();
        }
    }
}
