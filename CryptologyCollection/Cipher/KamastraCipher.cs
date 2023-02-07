using CryptologyCollection.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptologyCollection.Cipher
{
    internal class KamastraCipher : ICipher
    {
        public void RunCipher()
        {
            string upperHalf = "DZMCFTGNAVPUR";
            string lowerHalf = "JOQESXIHLWKYB";
            var dic = new Dictionary<char, char>();
            // save to dictionary
            for (int i = 0; i < upperHalf.Length; i++)
            {
                dic.Add(upperHalf[i], lowerHalf[i]);
            }

            Console.Write("Enter text: ");
            string inputText = Console.ReadLine().ToUpper();

            string output = String.Empty;
            foreach (char letter in inputText)
            {
                output += GetPair(dic, letter);
            }
            Console.WriteLine($"Output: {output}");
        }

        private static char GetPair(Dictionary<char, char> charPair, char letter)
        {
            foreach (var item in charPair)
            {
                if (item.Key == letter) return item.Value;
                if (item.Value == letter) return item.Key;
                if (letter == ' ') return ' ';
            }
            return new char();
        }

        
    }
}
