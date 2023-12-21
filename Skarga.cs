namespace Vibe {
    internal class Skarga {
        public void RozpatrzywanieSkargi(Administrator administrator) { }

        public DateTime Data               { get; set; }
        public string?  Decyzja            { get; set; }
        public string   Tresc              { get; set; } = null!;

        public List<Uzytkownik>        Skladajacy        { get; set; } = new();
        public List<Produkt>           Produkty          { get; set; } = new();
        public List<KampaniaReklamowa> KampanieReklamowe { get; set; } = new();
    }
}

