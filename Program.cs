using System;

class Program
{
    static void Main()
    {
        int health = 100;
        const int maxHealth = 100;

        while (health > 0)
        {
            Console.Clear();
            Console.WriteLine($"Health: {health}/{maxHealth}");
            Console.WriteLine("Velg handling:");
            Console.WriteLine("1) Spis (+10)");
            Console.WriteLine("2) Ta skade (-15)");
            Console.WriteLine("3) Sov (+25)");
            Console.WriteLine("4) Avslutt");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    health += 10;
                    break;
                case "2":
                    health -= 15;
                    break;
                case "3":
                    health += 25;
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Ugyldig valg. Trykk Enter...");
                    Console.ReadLine();
                    continue;
            }

            // Clamp til 0..maxHealth
            if (health > maxHealth) health = maxHealth;
            if (health < 0) health = 0;

            if (health == 0)
            {
                Console.WriteLine("Game Over");
                Console.ReadLine();
            }
        }
    }
}