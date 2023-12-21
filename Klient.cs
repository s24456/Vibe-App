namespace Vibe {
    internal class Klient : Uzytkownik {
        public void ZbanowanieUzytkownika() { }

        public override void LogowanieUzytkownika() => throw new NotImplementedException();
        public override void WylogowanieUzytkownika() => throw new NotImplementedException();
        public override void ZarzadzanieKontemUzytkownika() => throw new NotImplementedException();

        public string? Blokada { get; set; }
        public int     Wiek    { get; set; }

        public Abonament?    Abonament { get; set; }
        public List<Pytanie> Pytania   { get; set; } = new();
    }
}