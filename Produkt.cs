using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vibe {
    internal abstract class Produkt{
        public void PolubienieProduktu(Uzytkownik uzytkownik) { }

        public string              Nazwa           { get; set; } = null!;

        public List<Administrator> Administratorzy { get; set; } = new();
        public List<Skarga>        Skargi          { get; set; } = new();
        public List<Klient>        Klienci         { get; set; } = new();
        public List<Test>          Testy           { get; set; } = new();
    }
}
