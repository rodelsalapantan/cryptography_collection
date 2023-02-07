using CryptologyCollection.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptologyCollection.Cipher
{
    internal class PolybiusCipher : ICipher
    {
        public void RunCipher()
        {
            // NOTE: 'I' can be 'J' and vice versa
            string[,] alphArr = {
                { "A", "B", "C", "D", "E"},
                { "F", "G", "H", "I", "K"},
                { "L", "M", "N", "O", "P"},
                { "Q", "R", "S", "T", "U"},
                { "V", "W", "X", "Y", "Z"}
            };
            Console.WriteLine("Enter encrypted message: (separated by space)");
            string userInput = Console.ReadLine();
            string[] messageArr = userInput.Split(' ');

            string[] decryptedArr = new string[messageArr.Length];
            
            for(int i = 0; i < messageArr.Length; i++)
            {
                string numberStr = messageArr[i];

                int firstPos = Convert.ToInt32(Convert.ToString(numberStr[0])) - 1;
                int secondPos = Convert.ToInt32(Convert.ToString(numberStr[1])) - 1;

                decryptedArr[i] = alphArr[firstPos, secondPos];
            }

            string outputI = String.Empty;
            string outputJ = String.Empty;

            for (int i = 0; i < decryptedArr.Length; i++)
            {
                outputI += decryptedArr[i];

                if (decryptedArr[i] == "I")
                {
                    outputJ += "J";
                }
                else
                {
                    outputJ += decryptedArr[i];
                }
            }
            Console.WriteLine($"Output 'I': " + outputI);
            Console.WriteLine($"Output 'J': " + outputJ );
        }
    }
}
