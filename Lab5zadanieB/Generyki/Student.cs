namespace Generyki
{
    public class Student : IComparable<Student>
    {
        public string Nazwisko { get; set; }
        public double Ocena { get; set; }

        public int CompareTo(Student other)
        {
            if (other == null)
            {
                return 1;
            }
            return Ocena.CompareTo(other.Ocena);
        }

        public override string ToString()
        {
            return $"{Nazwisko}, Ocena = {Ocena}";
        }

    }
}
