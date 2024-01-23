using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vibe {
    internal class Pytanie {

        public DateOnly            DataDodania     { get; set; } = new();
        public string              Kategoria       { get; set; } = null!;
        public string              Tresc           { get; set; } = null!;
        private double             Waga            { get; set; } = 0.0D;

        public List<Test>          Testy           { get; set; } = new();
        public List<Administrator> Administratorzy { get; set; } = new();
    }
}
