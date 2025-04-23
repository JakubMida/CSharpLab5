using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy
{
    public class Student : IPoprawialny<Student>
    {
        public string Nazwisko {  get; set; }
        public double Ocena { get; set; }

        public Student PobierzLepszaWersje()
        {
            return new Student
            {
                Nazwisko = this.Nazwisko,
                Ocena = 4.0
            };
        }

        public override string ToString()
        {
            return $"{Nazwisko}, Ocena: {Ocena:f2}";
        }

    }
}
