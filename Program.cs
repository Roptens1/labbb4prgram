using System;
using System.Collections.Generic;

namespace labbb4prgram
{
    class Program
    {
        // en lista som sparar alla personer som läggs till den
        static List<Person> personer = new List<Person>();

        static void Main(string[] args)
        {
            // detta är en bool som styr om programmet ska fortsätta köra eller inte
            bool run = true;

            
            while (run)
            {
                
               
                Console.WriteLine("MENY");
                Console.WriteLine("1. Lägg till person");
                Console.WriteLine("2. Visa alla personer");
                Console.WriteLine("3. Avsluta");
                Console.Write("Välj: ");

                // Läser in användarens val alltså lässer om användaren vill lägga till person, visa personer eller avsluta
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
                        // Om användaren skriver något annat än en bokstav eller en siffra som inte finns i menyn så får den detta meddelande om att det är fel val
                        Console.WriteLine("Fel val. Tryck Enter.");
                        Console.ReadLine();
                        break;
                }
            }
        }

       
        //  FÖR ATT LÄGGA TILL EN PERSON
       
        static void AddPerson()
        {

            // Skapar ett nytt person objekt
            Person p = new Person();

            
            Console.Write("Namn: ");
            p.Namn = Console.ReadLine();

            
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

            // Skapar ett Hair objekt
            Hair har = new Hair();

            // Läser in hårlängd
            Console.Write("Hårlängd: ");
            har.Langd = Console.ReadLine();

            // Läser in hårfärg
            Console.Write("Hårfärg: ");
            har.Farg = Console.ReadLine();

            // Sparar hår informationen i personen
            p.Har = har;

            // Läser in födelsedatum (med felhantering om användaren väler fel år eller månad så för de en felmeddelande )
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

                    // Skapar ett DateTime objekt
                    p.Fodelsedag = new DateTime(år, månad, dag);
                    break;
                }
                catch
                {
                    
                    Console.WriteLine("Fel datum. Försök igen.");
                }
            }

            // Läser in ögonfärg
            Console.Write("Ögonfärg: ");
            p.Ogonfarg = Console.ReadLine();

            // Lägger till personen i listan
            personer.Add(p);

            Console.WriteLine("Personen är tillagd");
            Console.WriteLine("Tryck Enter för att fortsätta."); // Meddelande för att informera användaren att personen har lagts till och att trycka Enter för att fortsätta med den andra person eller avsluta.
            Console.ReadLine();
        }

       
        //  FÖR ATT VISA ALLA PERSONER
      
        static void ListPersons()
        {

          
            if (personer.Count == 0)
            {
                Console.WriteLine("Inga personer finns.");
            }
            else
            {
                // Loopar igenom alla personer i listan
                foreach (Person p in personer)
                {
                    // Skriver ut personens information
                    Console.WriteLine(p.ToString());
                    Console.WriteLine("--------------------");
                }
            }

            Console.WriteLine("Tryck Enter för att fortsätta.");
            Console.ReadLine();
        }
    }
}
