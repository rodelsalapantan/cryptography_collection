using CryptologyCollection.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptologyCollection.Cipher
{
    internal class AtbashCipher : ICipher
    {
        public void RunCipher()
        {
            // Caesar Shift Cipher
            string alphabetString = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] alphabet = alphabetString.ToCharArray();
            var pairChar = new Dictionary<char, char>();

            for(int i = alphabet.Length -1, j = 0; i >= 0 ; i--, j++)
            {
                pairChar.Add(alphabet[j], alphabet[i]);
            }
            foreach(var item in pairChar)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            Console.Write("Enter word/text: ");
            string userInput = Console.ReadLine().ToUpper();

            string result = String.Empty;

            foreach (char item in userInput)
            {
                result += GetPair(pairChar, item);
            }

            Console.WriteLine($"Output: {result}");
        }
        private static char GetPair(Dictionary<char, char> charPair, char letter)
        {
            foreach (var item in charPair)
            {
                if (item.Key == letter) return item.Value;
                if (letter == ' ') return ' ';
            }
            return new char();
        }
    }
}
