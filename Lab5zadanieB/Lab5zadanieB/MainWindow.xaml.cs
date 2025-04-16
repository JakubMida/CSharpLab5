using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Generyki;

namespace Lab5zadanieB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dictionary<string, Student> studenci;
        public MainWindow()
        {
            InitializeComponent();
            studenci = new Dictionary<string, Student>
            {
                {"1000", new Student{Nazwisko = "Polewczengo", Ocena = 2.5} },
                {"1001", new Student{Nazwisko = "Polewczenko", Ocena = 3.5} },
                {"1002", new Student{Nazwisko = "Polewczak", Ocena = 2.0} },
                {"1003", new Student{Nazwisko = "Polewski", Ocena = 4.5} },
            };
        }

        private void btnKlik_Click(object sender, RoutedEventArgs e)
        {
            string numerAlbumu = txtNumerAlbumu.Text;
            if (studenci.TryGetValue(numerAlbumu, out Student student))
            {
                MessageBox.Show($"Nazwisko: {student.Nazwisko}, Ocena: {student.Ocena}");
            }
            else
            {
                MessageBox.Show("Nieznaleziono takiego studenta!");
            }
        }

        private void btnPorownanie_Click(object sender, RoutedEventArgs e)
        {
            string s1 = "Grzesiu";
            string s2 = "Werka Sportsmenka";
            string wiekszyString = Porownywanie.ZnajdzWiekszy(s1, s2);
            MessageBox.Show(wiekszyString);

            double d1 = 5.5;
            double d2 = 10.5;
            double wiekszyDobule = Porownywanie.ZnajdzWiekszy(d1, d2);
            MessageBox.Show($"{wiekszyDobule}");

            Student st1 = new Student { Nazwisko = "Polewska", Ocena = 60};
            Student st2 = new Student { Nazwisko = "Sportsmenka", Ocena = 2.5 };
            Student wiekszyStudent = Porownywanie.ZnajdzWiekszy(st1, st2);
            MessageBox.Show($"{ wiekszyStudent}");
            

        }

        private void bntPolka_Click(object sender, RoutedEventArgs e)
        {
            var regal = new Regal<double>();
            regal.Polka1 = 1.1;
            regal.WolnaPolka = 2.2;
            regal.WstawNaWolnaPolke(3.3);

            MessageBox.Show(regal.ToString());

            var regalStudent = new Regal<Student>();
            regalStudent.Polka1 = new Student { Nazwisko = "Polewska", Ocena = 2.0 };
            regalStudent.WolnaPolka = new Student { Nazwisko = "Polewicznka", Ocena = 2.0};
            regalStudent.WstawNaWolnaPolke(new Student { Nazwisko = "PrzeSZCZEPanik", Ocena = 5.0 });
            MessageBox.Show(regalStudent.ToString());

        }
    }
}