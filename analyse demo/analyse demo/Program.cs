namespace analyse_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string user = "Dylano", password = "PXL123";
            int tries = 0;

            while (tries < 3)
            {
                Console.Write ("Gebruikersnaam: ");
                string inputuser = Console.ReadLine();
                Console.Write("Wachtwoord: ");
                string inputPassword = Console.ReadLine(); 

                if (inputuser == user && inputPassword == password)
                {
                    Console.WriteLine($"Welkom, {inputuser}");
                    return;
                }
                tries++;
                Console.WriteLine($"Foutive login.\n {3 - tries} pogingen over");
            }
            Console.WriteLine("te veel pogingen. geen toegang");
        }
    }
}
