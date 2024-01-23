namespace Vibe {
    internal abstract class Uzytkownik {

        public abstract void LogowanieUzytkownika();
        public void PrzegladanieOfertySerwisu() { }
        public static void RejestracjaUzytkownika() { }
        public abstract void WylogowanieUzytkownika();
        public abstract void ZarzadzanieKontemUzytkownika();

        public string Email { get; set; } = null!;
        public string Imie { get; set; } = null!;
        public string Login        { get; set; } = null!;
        public string Nazwisko     { get; set; } = null!;

        public List<Skarga> Skargi { get; set; } = new();
    }
}