using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace KolosZadanieA
{
    class Pudelko<T>
    {
        private T[] przegrodki;
        public Pudelko(int liczbaPrzegrodek)
        {

            if(liczbaPrzegrodek <= 0)
            {
                throw new ArgumentException("Liczba przegrodek nie może być ujemna!");
            }
            przegrodki = new T[liczbaPrzegrodek];
        }

        public void Wloz(T element, int nrPrzegrodki)
        {
            if(nrPrzegrodki < 0 || nrPrzegrodki > przegrodki.Length)
            {
                throw new ArgumentException("Numer przegródki poza zakresem!");
            }

            przegrodki[nrPrzegrodki] = element;
        }

        public T Wyciagnij(int nrPrzegrodki)
        {
            if (nrPrzegrodki < 0 || nrPrzegrodki > przegrodki.Length)
            {
                throw new ArgumentException("Numer przegródki poza zakresem!");
            }
            return przegrodki[nrPrzegrodki];
        }

    }
}
