using System;
using System.Collections.Generic;

namespace labbb4prgram
{
    class Program
    {
        // Lista som sparar alla personer
        static List<Person> personer = new List<Person>();

        static void Main(string[] args)
        {
            bool run = true;

            while (run)
            {
                Console.Clear();
                Console.WriteLine("MENY");
                Console.WriteLine("1. Lägg till person");
                Console.WriteLine("2. Visa alla personer");
                Console.WriteLine("3. Avsluta");
                Console.Write("Välj: ");

                string val = Console.ReadLine();

                switch (val)
                {
                    case "1":
                        AddPerson();
                        break;

                    case "2":
                        ListPersons();
                        break;

                    case "3":
                        run = false;
                        break;

                    default:
                        Console.WriteLine("Fel val. Tryck Enter.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        // =====================
        // LÄGG TILL PERSON
        // =====================
        static void AddPerson()
        {
            Console.Clear();
            Person p = new Person();

            Console.Write("Namn: ");
            p.Namn = Console.ReadLine();

            // Kön (enkelt)
            while (true)
            {
                Console.Write("Kön (0=Kvinna, 1=Man, 2=IckeBinar, 3=Annan): ");
                int kon = int.Parse(Console.ReadLine());

                if (kon >= 0 && kon <= 3)
                {
                    p.Kon = (Gender)kon;
                    break;
                }
                else
                {
                    Console.WriteLine("Fel. Skriv en siffra mellan 0 och 3.");
                }
            }

            // Hår
            Hair har = new Hair();

            Console.Write("Hårlängd: ");
            har.Langd = Console.ReadLine();

            Console.Write("Hårfärg: ");
            har.Farg = Console.ReadLine();

            p.Har = har;

            // Födelsedatum (enkelt + säkert)
            while (true)
            {
                try
                {
                    Console.Write("Födelseår: ");
                    int år = int.Parse(Console.ReadLine());

                    Console.Write("Födelsemånad: ");
                    int månad = int.Parse(Console.ReadLine());

                    Console.Write("Födelsedag: ");
                    int dag = int.Parse(Console.ReadLine());

                    p.Fodelsedag = new DateTime(år, månad, dag);
                    break;
                }
                catch
                {
                    Console.WriteLine("Fel datum. Försök igen.");
                }
            }

            Console.Write("Ögonfärg: ");
            p.Ogonfarg = Console.ReadLine();

            // Lägg till i listan
            personer.Add(p);

            Console.WriteLine("Personen är tillagd!");
            Console.WriteLine("Tryck Enter för att fortsätta.");
            Console.ReadLine();
        }

        
        // VISA ALLA PERSONER
        
        static void ListPersons()
        {
            Console.Clear();

            if (personer.Count == 0)
            {
                Console.WriteLine("Inga personer finns.");
            }
            else
            {
                foreach (Person p in personer)
                {
                    Console.WriteLine(p.ToString());
                    Console.WriteLine("--------------------");
                }
            }

            Console.WriteLine("Tryck Enter för att fortsätta.");
            Console.ReadLine();
        }
    }
}
