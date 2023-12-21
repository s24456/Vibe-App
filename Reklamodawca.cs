namespace Vibe {
    internal class Reklamodawca : Uzytkownik {
        public override void LogowanieUzytkownika() => throw new NotImplementedException();
        public override void WylogowanieUzytkownika() => throw new NotImplementedException();
        public override void ZarzadzanieKontemUzytkownika() => throw new NotImplementedException();

        public string                  AdresRozliczeniowy { get; set; } = null!;
        public string                  NIP                { get; set; } = null!;
        public string                  NumerTelefonu      { get; set; } = null!;
        public List<KampaniaReklamowa> Kampanie           { get; set; } = new();

    }
}