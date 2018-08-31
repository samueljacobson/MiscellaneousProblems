using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscellany
{
    class Program
    {
        static void Main(string[] args)
        {
            //Palindrome checker
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            char[] wordArray = word.ToCharArray();
            bool isPalindrome;
            bool[] isPalindromeArray = new bool[wordArray.Length];

            for (int i = 0; i < wordArray.Length; i++)
            {
                //Console.WriteLine(wordArray[i]);
                //Console.WriteLine(wordArray[wordArray.Length - 1 - i]);
                if (wordArray[i] == wordArray[wordArray.Length - 1 - i])
                {
                    isPalindrome = true;
                }
                else
                {
                    isPalindrome = false;
                }

                isPalindromeArray[i] = isPalindrome;

            }

            if (isPalindromeArray.Contains(false))
            {
                Console.WriteLine("Sorry, {0} is NOT a palindrome", word);
            }
            else
            {
                Console.WriteLine("{0} is a palindrome", word);
            }

            //Return first 10 multiples of an integer
            Console.Write("Enter an integer: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n*i);
            }

            //Call Reverse method
            Console.Write("Enter a word to reverse: ");
            string wordUser = Console.ReadLine();
            Console.WriteLine(Reverse(wordUser));
            Console.WriteLine(Reverse("dog"));
        }

        //Method to reverse a string
        public static string Reverse(string word)
        {
            char[] wordArray = word.ToCharArray();
            string wordReverse = "";
            for (int i = wordArray.Length - 1; i > -1; i--)
            {
                wordReverse += wordArray[i];
            }
            return wordReverse;
        }
    }
}