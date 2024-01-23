using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Vibe {
    internal class Abonament {
        public void AktywacjaAbonamentu() { }
        public static void StworzenieAbonamentu() { }

        public double Koszt { get; set; }
        public string Okres { get; set; } = null!;
        public double? Ulga { get; set; } = null;

        public List<Klient>        Klienci         { get; set; } = new();
        public List<Administrator> Administratorzy { get; set; } = new();
    }
}
