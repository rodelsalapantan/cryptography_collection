using CryptologyCollection.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptologyCollection.Cipher
{
    internal class SimpleTranspositionCipher : ICipher
    {
        public void RunCipher()
        {
            Console.Write("Enter word/text: ");

            string output = String.Empty;
            string userInput = Console.ReadLine();


            string[] wordArr = userInput.Split(' ');
            foreach(var word in wordArr)
            {
                string result = String.Empty;
                for(int i = word.Length - 1; i >= 0; i--)
                {
                    result += word[i];
                }
                output += result + " ";
            }
            Console.WriteLine(output.TrimEnd());
        }
    }
}
