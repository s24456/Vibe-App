namespace Vibe {
    internal class Test {
        public void WypelnienieTestuEmocjalnego() { }

        public DateTime      Data         { get; set; } = new();
        public Klient        Klient       { get; set; } = null!;
        public Pytanie       Pytania      { get; set; } = null!;
        public List<Produkt> Rekomendacje { get; set; } = new();
    }
}
