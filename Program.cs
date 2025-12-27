using System;

namespace labbb4prgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa hår
            Hair har = new Hair();
            har.Langd = "Kort";
            har.Farg = "gul";

            // Skapa person
            Person person = new Person();
            person.Namn = "Bakir";
            person.Kon = Gender.Man;
            person.Hår = har;
            person.Fodelsedag = new DateTime(1590, 4, 15);
            person.Ögonfarg = "Blå";

            // Skriv ut
            Console.WriteLine(person.ToText());
            Console.WriteLine("text");
            Console.WriteLine("text");
            Console.WriteLine("text");
            Console.WriteLine("text");
            Console.WriteLine("text");



        }
    }
}