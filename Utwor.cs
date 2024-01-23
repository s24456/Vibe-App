using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vibe {
    internal class Utwor : Produkt {
        public static void DodanieUtworu(params string[] daneUtworu) { }
        public static void EdycjaUtworu() { }
        public void OdtworzenieUtworu() { } 
        public void ZarzadzanieUtworami(Uzytkownik uzytkownik) { }

        public static void UsuniecieUtworu() { }
        public static void ZwrocenieDanychOWszystkichUtworach(params string[] daneposzukowe) { }

        public string          Gatunek      { get; set; } = null!;
        public int             RokProdukcji { get; set; } = 0;
        public string?         Tekst        { get; set; }
        public List<Skladanka> Skladanki    { get; set; } = new();
    }
}
