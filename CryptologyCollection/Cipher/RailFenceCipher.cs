using CryptologyCollection.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptologyCollection.Cipher
{
    internal class RailFenceCipher : ICipher
    {
        public void RunCipher()
        {
            Console.Write("Enter Rails (Rows): ");
            int userInputRails = Convert.ToInt32(Console.ReadLine());

            if (userInputRails <= 1)
            {
                Console.WriteLine("Invalid Rows, try again!");
                return;
            }

            Console.Write("Encrypted Message (Enter text seperated with space): ");
            string userInputMsg = Console.ReadLine();
            userInputMsg = userInputMsg.Trim(); // trim both start and end
            string[] separatedMsg = userInputMsg.Split(' ');
            if (separatedMsg.Length <= 1)
            {
                Console.WriteLine("Invalid Input, try again!");
                return;
            }

            int totalMsgLength = 0;
            foreach (var item in separatedMsg)
            {
                totalMsgLength += item.Length;
            }

            int totalColumn = totalMsgLength / userInputRails;
            int remainder = totalMsgLength % userInputRails;
            totalColumn = remainder > 0 ? ++totalColumn : totalColumn;

            char[,] multiDimArr = new char[userInputRails, totalColumn];

            for (int i = 0; i < userInputRails; i++)
            {

                for (int j = 0, k = totalColumn; j < totalColumn; j++, k--)
                {
                    multiDimArr[i, j] = separatedMsg[i][j];
                }
            }
            Console.WriteLine("--------------");

            string output = String.Empty;
            for (int i = 0; i < totalColumn; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < userInputRails; j++) output += multiDimArr[j, i];
                }
                else
                {
                    for (int j = userInputRails - 1; j >= 0; j--) output += multiDimArr[j, i];
                }
            }

            string finalOutput = String.Empty;
            foreach(char item in output)
            {
                if (item != '-') finalOutput += item;
            }
            Console.WriteLine($"Output: {finalOutput}");

        }
    }
}
