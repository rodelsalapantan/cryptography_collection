using CryptologyCollection.Cipher;
using CryptologyCollection.Contracts;

namespace CryptologyCollection
{
    class Program
    {
        private static void Main(string[] args)
        {
            bool flagContinue = true;
            // ****
            // **** Save All Cipher in List of CipherModel
            // ****
            var cipherList = new List<CipherModel>()
            {
                new CipherModel( 1, "Caesar Shift Cipher", new CaesarShiftCipher()),
                new CipherModel( 2, "Kamasutra Cipher", new KamastraCipher()),
                new CipherModel( 3, "Simple Transposition Cipher", new SimpleTranspositionCipher()),
                new CipherModel( 4, "Atbash Cipher", new AtbashCipher()),
                new CipherModel( 5, "Rail Fence Cipher", new RailFenceCipher()),
                new CipherModel( 6, "Polybius Cipher", new PolybiusCipher()),
                new CipherModel( 7, "Bifid Cipher", new BifidCipher())
            };

            while (flagContinue)
            {
                WriteTextLine("---------- Modes ----------");

                foreach (var item in cipherList)
                {
                    WriteTextLine($"{item.Id} - {item.Title}");
                }

                LineDivider();
                Console.Write("Enter Cipher Mode: ");
                int selectedMode = Convert.ToInt32(InputPrompter());

                foreach(var item in cipherList)
                {
                    if(item.Id == selectedMode)
                    {
                        int inputId = selectedMode - 1;

                        WriteTextLine($"---- {cipherList[inputId].Title} ---- ");
                        ICipher objResult = cipherList[inputId].CipherObject;
                        objResult.RunCipher();
                    }
                }

                flagContinue = IsContinue();
            }
            LineDivider();
            WriteTextLine("Thank you for using our Cryptology Collection :>");
        }
        // Display Line Divider
        private static void LineDivider() => Console.WriteLine("---------------------------");
        
        // Display provided string/text
        private static void WriteTextLine(dynamic word) => Console.WriteLine(word);
        private static void WriteText(dynamic word) => Console.Write(word);

        // Prompt user to enter word
        private static string InputPrompter() => Console.ReadLine();

        // Ask user if she/he wants to continue or not
        private static bool IsContinue()
        {
            LineDivider();
            WriteText("Continue? y/n: ");

            string userInput = InputPrompter();
            string userLower = userInput.ToLower();

            return userLower == "y" || userLower == "yes";
        }
    }
}
