using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolosZadanieB
{
    public class Armata
    {
        public int Kaliber {  get; set; }
        public int Masa {  get; set; }

        public override string ToString()
        {
            return $"Kaliber: {Kaliber}, masa: {Masa}";
        }
    }
}
