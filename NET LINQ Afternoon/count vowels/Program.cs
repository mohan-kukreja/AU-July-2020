using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Net_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
             var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
        
            Console.Write("Enter a Sentence ");
            string word = Console.ReadLine().ToLower();
            Console.Write(word);
        
            int total = word.Count(c => vowels.Contains(c));
            Console.WriteLine(" ");
            Console.WriteLine("Your total number of vowels is: {0}", total);
            //Console.ReadLine();
        }
    }
}
