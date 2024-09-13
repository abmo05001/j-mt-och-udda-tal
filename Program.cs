using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int slumptal = random.Next(1, 101);  // Väljer ett slumptal mellan 1 och 100
        int försök = 0;
        int gissning = 0;

        Console.WriteLine("Jag har valt ett tal mellan 1 och 100. Försök att gissa vilket det är!");

        while (gissning != slumptal)
        {
            Console.Write("Din gissning: ");
            gissning = int.Parse(Console.ReadLine());
            försök++;

            if (gissning < slumptal)
            {
                Console.WriteLine("För låg gissning. Försök igen!");
            }
            else if (gissning > slumptal)
            {
                Console.WriteLine("För hög gissning. Försök igen!");
            }
            else
            {
                Console.WriteLine($"Rätt tal! Du gissade rätt på {försök} försök.");
            }
        }
    }
}

