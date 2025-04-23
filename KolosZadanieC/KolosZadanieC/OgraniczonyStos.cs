using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolosZadanieC
{
    class OgraniczonyStos<T>
    {
        private T[] dane;
        private int aktualnyIndex;
        
        public OgraniczonyStos(int pojemnosc)
        {
            if(pojemnosc <= 0)
            {
                throw new ArgumentException("Pojemnosc musi być większa od 0");
            }
            dane = new T[pojemnosc];
            aktualnyIndex = -1;
        }

        public void Dodaj(T element)
        {
            if (aktualnyIndex == dane.Length-1)
            {
                throw new ArgumentException("Stos jest pełny!");
            }
            aktualnyIndex++;
            dane[aktualnyIndex] = element;
        }

        public T Pobierz()
        {
            if(aktualnyIndex == -1)
            {
                throw new ArgumentException("Stos jest pusty!");
            }
            T element = dane[aktualnyIndex];
            aktualnyIndex--;
            return element;
        }

        public bool CzyPusty()
        {
            return aktualnyIndex < 0; 
        }

    }
}
