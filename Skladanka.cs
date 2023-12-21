using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vibe {
    internal class Skladanka : Produkt {
        public void OdtworzenieSkladanki() { }
        public void ZarzadzanieSkladankami(Uzytkownik uzytkownik) { }

        public static void DodanieSkladanki() { }

        public DateOnly    Data          { get; set; }
        public int         IloscPolubien { get; set; } = 0;
        public List<Utwor> Utwory        { get; set; } = new();
    }
}