namespace Vibe {
    internal class Reklama {
        public void ZarzadzanieReklamami() { }

        public string Nazwa               { get; set; } = null!;
        public string Target              { get; set; } = null!;
        public string Tresc               { get; set; } = null!;
        public KampaniaReklamowa Kampania { get; set; } = null!;
    }
}
