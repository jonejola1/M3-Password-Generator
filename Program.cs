namespace M3_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            PromtUser();
        }

        static void PromtUser()
        {
            Console.WriteLine("Min. 1 lower case (l)\nMin. 1 upper case (L)\nMin. 2 special characters (s)\nMin. 2 digits (d)");
            Console.Write("Skriv inn antall tegn: ");

            var symbols = Convert.ToInt32(Console.ReadLine());

            Console.Write("Skriv inn krav: ");

            string optionInput = Console.ReadLine();
            foreach (char c in optionInput)
            {
                if (c != 'l' && c != 'L' && c != 's' && c != 'd')
                    PromtUser();
            }

            Console.WriteLine(symbols + " " + optionInput);
            Console.Read();
        }
    }
}
