namespace Klasy
{
    public class Samochod : IZwiększany, IZmniejszany, IPoprawialny<Samochod>
    {
        public int Predkosc { get; set; }

        void IZwiększany.Zmien()
        {
            Predkosc += 10;
        }

        void IZmniejszany.Zmien()
        {
            Predkosc -= 5;
        }

        public override string ToString()
        {
            return $"Prędkość = {Predkosc} km/h";
        }

        public Samochod PobierzLepszaWersje()
        {
            return new Samochod
            {
                Predkosc = Predkosc + 30
            };
        }

    }
}
