using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace labbb4prgram
{
    // Enum för kön
    enum Gender
    {
        Kvinna,
        Man,
        IckeBinar,
        Annan,
        du
    }

    // Struct för hår
    struct Hair
    {
        public string Langd;
        public string Farg;
    }

    // Klass för person
    class Person
    {
        public string Namn;
        public Gender Kon;
        public Hair Hår;
        public DateTime Fodelsedag;
        public string Ögonfarg;

        public string ToText()
        {
            return
                "Namn: " + Namn + "\n" +
                "Kön: " + Kon + "\n" +
                "Hår: " + Hår.Langd + ", " + Hår.Farg + "\n" +
                "Födelsedag: " + Fodelsedag.ToShortDateString() + "\n" +
                "Ögonfärg: " + Ögonfarg;
        }
    }
}
