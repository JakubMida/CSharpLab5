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

namespace Lab5Zad2WDomu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, Student> studenci;


        public MainWindow()
        {
            InitializeComponent();
            studenci = new Dictionary<string, Student>
            {
                {"1000", new Student{Nazwisko= "Polewczenko", Ocena = 3.5}},
                {"1001", new Student {Nazwisko= "Stupkaziak", Ocena = 4.5} },
                {"1002", new Student {Nazwisko = "Przeszczepanik", Ocena = 2.5} },
                {"1003", new Student {Nazwisko = "Kowal", Ocena = 5.0} }
            };
        }

        private void btnSzukaj_Click(object sender, RoutedEventArgs e)
        {
            string numerAlbumu = txtNumerAlbumu.Text;

            if (studenci.TryGetValue(numerAlbumu, out Student student))
            {
                MessageBox.Show($"Nazwisko: {student.Nazwisko}, Ocena: {student.Ocena:f2}.");
            }
            else
            {
                MessageBox.Show("Nieznaleziono studenta z takim numerem albumu.");
            }
        }

        private void btnPorownywarka_Click(object sender, RoutedEventArgs e)
        {
            string wiekszyString = Porownywarka.ZnajdzWiekszy("Ala", "Aleksandra");
            double wiekszyDouble = Porownywarka.ZnajdzWiekszy(4.55, 4.56);
            Student student1 = new Student { Nazwisko = "Kowal", Ocena = 3.5 };
            Student student2 = new Student { Nazwisko = "Nowak", Ocena = 4.0 };
            Student wiekszyStudent = Porownywarka.ZnajdzWiekszy(student1, student2);
            MessageBox.Show($"Większy string {wiekszyString}");
            MessageBox.Show($"Większy double {wiekszyDouble}");
            MessageBox.Show($"\"Większy\" student {wiekszyStudent}");

        }

        private void btnRegal_Click(object sender, RoutedEventArgs e)
        {
            Regal<double> regalDouble = new Regal<double>();
            MessageBox.Show($"{regalDouble}");
            regalDouble.Polka1 = 1.1;
            regalDouble.WolnaPolka = 2.2;
            regalDouble.WstawNaWolnaPolke(3.3);

            MessageBox.Show($"{regalDouble}");

            Regal<Student> regalStudent = new Regal<Student>();
            regalStudent.Polka1 = new Student { Nazwisko = "Nowak", Ocena = 3.5 };
            regalStudent.WstawNaWolnaPolke(new Student { Nazwisko = "Kowal", Ocena = 4.0 });
            regalStudent.WolnaPolka = new Student { Nazwisko = "Polewczenko", Ocena = 3.0 };
            MessageBox.Show($"{regalStudent}");
        }
    }
}