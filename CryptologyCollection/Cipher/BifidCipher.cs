using CryptologyCollection.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptologyCollection.Cipher
{
    internal class BifidCipher : ICipher
    {
        public void RunCipher()
        {
            string[,] alphArr = {
                { "A", "B", "C", "D", "E"},
                { "F", "G", "H", "I", "K"},
                { "L", "M", "N", "O", "P"},
                { "Q", "R", "S", "T", "U"},
                { "V", "W", "X", "Y", "Z"}
            };

            Console.Write("Enter encrypted message: ");
            string userInput = Console.ReadLine();
        }
    }
}
