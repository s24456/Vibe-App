using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vibe {
    internal class KampaniaReklamowa : Produkt_KampaniaReklamowa {
        public void RozpatrywanieKampaniiReklamowej(Administrator administrator) { }

        public static void ZlozenieKampaniiReklamowej(int budzet, int iloscOdtworzen, DateTime okres) { }

        public int           Budzet          { get; set; }
        public int           IloscOdtworzen  { get; set; }
        public DateTime      Okres           { get; set; }

        public List<Reklama> Reklamy         { get; set; } = new();
        public Reklamodawca  Reklamodawca    { get; set; } = null!;
        public List<Skarga>  Skargi          { get; set; } = new();
        public Administrator Administrator   { get; set; } = new();
    }
}
