namespace Vibe {
    internal class Administrator : Uzytkownik {
        public override void LogowanieUzytkownika() => throw new NotImplementedException();
        public override void WylogowanieUzytkownika() => throw new NotImplementedException();
        public override void ZarzadzanieKontemUzytkownika() => throw new NotImplementedException();

        public string KanałKomunikacji  { get; set; } = null!;
        public List<string> Uprawnienia { get; set; } = new();

        public List<Abonament>         Abonamenty        { get; set; } = new();
        public List<Pytanie>           Pytania           { get; set; } = new();
        public List<Produkt>           Produkty          { get; set; } = new();
        public List<KampaniaReklamowa> KampanieReklamowe { get; set; } = new();
    }
}