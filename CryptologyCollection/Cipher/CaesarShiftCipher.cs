using CryptologyCollection.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptologyCollection.Cipher
{
    internal class CaesarShiftCipher : ICipher
    {
       
        public void RunCipher()
        {
            Console.ForegroundColor = ConsoleColor.White;

            // Caesar Shift Cipher
            string alphabetString = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] alphabet = alphabetString.ToCharArray();

            Console.Write($"Enter shift number (0 to {alphabet.Length}): ");

            Console.ForegroundColor = ConsoleColor.Cyan;
            int numShift = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;

            if (numShift > alphabetString.Length || numShift < 0)
            {
                Console.WriteLine("Invalid Shifting Number");
                return;
            }

            char[] shiftedAlphabet = ShiftArray(alphabet, numShift);
            Console.Write("Enter text: ");

            Console.ForegroundColor = ConsoleColor.Cyan;
            string userText = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;

            string output = String.Empty;
            foreach (char letter in userText)
            {
                if (letter == ' ')
                {
                    output += " ";
                }
                else
                {
                    int letterIndex = Array.IndexOf(alphabet, letter);
                    output += shiftedAlphabet[letterIndex];
                }

            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Output: {output}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static char[] ShiftArray(char[] arr, int shiftNumber)
        {
            char[] shiftedArr = new char[arr.Length];
            for (int i = 0, j = 0; i < arr.Length; i++)
            {
                int currentIndex = shiftNumber + i;
                if (currentIndex < arr.Length)
                {
                    shiftedArr[i] = arr[currentIndex];
                }
                else
                {
                    shiftedArr[i] = arr[j];
                    j++;
                }
            }
            return shiftedArr;
        }
    }
    
}
