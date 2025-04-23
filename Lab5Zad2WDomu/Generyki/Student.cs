namespace Generyki
{
    public class Student : IComparable<Student>
    {
        public string Nazwisko {  get; set; }
        public double Ocena { get; set; }

        public int CompareTo(Student other)
        {
            if(this == other) return 1;
            return this.Ocena.CompareTo(other.Ocena);
        }

        public override string ToString()
        {
            return $"{Nazwisko}, ocena: {Ocena:f2}";
        }
    }
}
