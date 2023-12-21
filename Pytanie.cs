using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vibe {
    internal class Pytanie {
        public DateOnly   DataDodania { get; set; }
        public string     Kategoria   { get; set; } = null!;
        public List<Test> Odpowiedzi  { get; set; } = null!;
        public string     Tresc       { get; set; } = null!;
        private double    Waga        { get; set; } = 0.0D;

        public List<Klient>        Klienci         { get; set; } = new();
        public List<Administrator> Administratorzy { get; set; } = new();
    }
}
