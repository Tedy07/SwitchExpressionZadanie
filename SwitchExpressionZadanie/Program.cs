namespace SwitchExpressionZadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPodaj pierwszą liczbę ...");
            double numberFirst = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę ...");
            double numberSecend = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPodaj numer operacji do wykonania:");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie\n");

            int selected = int.Parse(Console.ReadLine());

            var reaction = selected switch
            {
                1 => numberFirst,
                2 => numberFirst,
                3 => numberSecend,
                4 => numberSecend,
                _ => 0,
            };
            Console.WriteLine($"Twój wynik to {reaction}");

            // Działający program
        }
    }
}