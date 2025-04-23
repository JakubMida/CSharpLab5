using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generyki
{
    public class Regal<T>
    {
        public T Polka1 { get; set; } = default(T);
        public T Polka2 { get; set; } = default(T);
        public T Polka3 { get; set; } = default(T);

        public override string ToString()
        {
            return $"Półka1: {Polka1}, Półka2: {Polka2}, Półka3: {Polka3}";
        }

        public void WstawNaWolnaPolke(T wartosc)
        {
            if(Equals(Polka1,default(T)))
            {
                this.Polka1 = wartosc; 
            }else if(Equals(Polka2, default(T)))
            {
                this.Polka2 = wartosc;
            }else if(Equals(Polka3,default(T)))
            {
                this.Polka3 = wartosc;
            }

        }

        public T WolnaPolka
        {
            set
            {
                WstawNaWolnaPolke(value);
            }
        }


    }
}
