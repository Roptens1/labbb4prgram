using System;

namespace labbb4prgram
{
    class Person
    {
        public string Namn { get; set; }
        public Gender Kon { get; set; }
        public Hair Har { get; set; }
        public DateTime Fodelsedag { get; set; }
        public string Ogonfarg { get; set; }

        public override string ToString()
        {
            return
                $"Namn: {Namn}\n" +
                $"Kön: {Kon}\n" +
                $"Hår: {Har.Langd}, {Har.Farg}\n" +
                $"Födelsedag: {Fodelsedag.ToShortDateString()}\n" +
                $"Ögonfärg: {Ogonfarg}";
        }
    }
}