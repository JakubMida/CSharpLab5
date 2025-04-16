using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Stozek
    {
        public delegate void ObslugaBledu(string opisBledu);
        public event ObslugaBledu Blad;

        private double promien;
        private double wysokosc;

        public double Promien
        {
            get { return promien; }
            set
            {
                if (value <= 0)
                {
                    if (Blad != null)
                    {
                        Blad($"Promień musi być dodatni!");
                    }
                }
                promien = value;
            }
        }

        public double Wysokosc
        {
            get { return wysokosc; }
            set
            {
                if (value <= 0)
                {
                    if (Blad != null)
                    {
                        Blad($"Wysokość musi być dodatnia!");
                    }
                }
                wysokosc = value;
            }
        }
    }
}
