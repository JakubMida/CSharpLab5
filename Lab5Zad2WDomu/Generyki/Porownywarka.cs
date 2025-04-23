using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generyki
{
    public static class Porownywarka
    {
        public static T ZnajdzWiekszy<T>(T a, T b) where T:IComparable<T>
        {
            if (a.CompareTo(b) >= 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
