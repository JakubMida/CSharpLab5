using System.Runtime.CompilerServices;

namespace Figury
{
    public class Stozek
    {
        private double promien;
        private double wysokosc;
        public delegate void ObslugaBledu(string opisBledu);
        public event ObslugaBledu Blad;

        public double Promien
        {
            get { return promien; }
            set
            {
                if (value <= 0 && Blad != null)
                {
                    Blad("Promień nie może być ujemny!");
                }
                promien = value;
            }
        }

        public double Wysokosc
        {
            get { return wysokosc; }
            set
            {
                if (value <= 0 && Blad != null)
                {
                    Blad("Wyskość musi być dodatnia!");
                }
                wysokosc = value;
            }
            
        }


    }
}
