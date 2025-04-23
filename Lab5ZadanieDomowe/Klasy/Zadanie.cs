using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy
{
    public class Zadanie
    {
        public string Opis { get; set; }
        public DateTime DataWprowadzenia { get; set; }  

        public Zadanie(string opis)
        {
            Opis = opis;
            DataWprowadzenia = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Opis}, {DataWprowadzenia}";
        }
    }
}
