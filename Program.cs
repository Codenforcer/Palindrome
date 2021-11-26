// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user to input a word to check if it is a Palindrome and save to a variable.
            Console.WriteLine("Please input a word to check if it is a Palindrome: ");
            string userInput = Console.ReadLine();

            // Empty string to store the reversed word.
            string reversedString = "";

            // For loop to reverse userinput and save into reverseString variable.
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                reversedString += userInput[i];
                    
            }

            // If/else statement to check if user word and reverse word match and present outcome.
            if (userInput.ToLower() == reversedString.ToLower())
            {
                Console.WriteLine("This word is a Palindrome");
            }
            else
            {
                Console.WriteLine("This word is not a Palindrome");
            }
        }


    }
    
}
