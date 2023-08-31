using System.Text.RegularExpressions;

namespace M3_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            PromtUser();
        }
        static string optionInput = "";
        static int symbols = 0;
        static void PromtUser()
        {
            Console.WriteLine("Min. 1 lower case (l)\nMin. 1 upper case (L)\nMin. 2 special characters (s)\nMin. 2 digits (d)");
            Console.Write("Skriv inn antall tegn: ");

            symbols = Convert.ToInt32(Console.ReadLine());

            Console.Write("Skriv inn krav: ");

            string optionInput = Console.ReadLine();
            foreach (char c in optionInput)
            {
                if (c != 'l' && c != 'L' && c != 's' && c != 'd')
                    PromtUser();
            }

            Console.WriteLine(symbols + " " + optionInput);
            GeneratePassword();
        }

        static void GeneratePassword()
        {
            string pattern = "";
            for (int i = 0; i < symbols; i++)
            {
                while (i < optionInput.Length)
                {
                    pattern += optionInput[i];
                }
                pattern += 'l';
            }
            Console.WriteLine(pattern);
            Console.WriteLine(WriteRandomLowerCaseLetter());
            WriteRandomDigits();
        }

        static char WriteRandomLowerCaseLetter()
        {
            Random rnd = new Random();
            int randonumber = rnd.Next(0, 26);
            char[] randomLowerCaseLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            return randomLowerCaseLetters[randonumber];
        }

        static char WriteRandomUpperCaseLetter()
        {
            Random rnd = new Random();
            int randonumber = rnd.Next(0, 26);
            char[] randomUpperCaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            return randomUpperCaseLetters[randonumber];
        }

        static int WriteRandomDigits()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, 9+1);
            return randomNumber;
        }

        static char WriteRandomSpecialCharacter()
        {
            Random rnd = new Random();
            char[] randomSpecialCharacters = { '@', '!', '#', '%', '?', '$', '£' };

            return randomSpecialCharacters[rnd.Next(0, randomSpecialCharacters.Length)];
        }
    }
    
}
