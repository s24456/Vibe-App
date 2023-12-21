namespace Vibe {
    internal abstract class Uzytkownik {
        public void PrzegladanieOfertySerwisu() { }

        public abstract void LogowanieUzytkownika();
        public abstract void WylogowanieUzytkownika();
        public abstract void ZarzadzanieKontemUzytkownika();

        public static void RejestracjaUzytkownika() { }

        public string Login        { get; set; } = null!;
        public string EMail        { get; set; } = null!;
        public string Imie         { get; set; } = null!;
        public string Nazwisko     { get; set; } = null!;

        public List<Skarga> Skargi { get; set; } = new();
    }
}