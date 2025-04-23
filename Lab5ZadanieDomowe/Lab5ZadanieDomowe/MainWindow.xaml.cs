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
using Klasy;

namespace Lab5ZadanieDomowe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Queue<Zadanie> kolejkaZadan = new Queue<Zadanie>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSamochod_Click(object sender, RoutedEventArgs e)
        {
            listSamochod.Items.Clear();
            Samochod auto = new Samochod { Predkosc = 0 };
            listSamochod.Items.Add(auto.ToString());

            IZwiększany przyspiesz = auto;
            przyspiesz.Zmien();
            listSamochod.Items.Add(auto.ToString());

            przyspiesz.Zmien();
            listSamochod.Items.Add(auto.ToString());

            IZmniejszany zwolnij = auto;
            zwolnij.Zmien();
            listSamochod.Items.Add(auto.ToString());

            
        }

        private void btnLepszaWersja_Click(object sender, RoutedEventArgs e)
        {
            listaLepsza.Items.Clear();

            Student student = new Student { Nazwisko = "Nowak", Ocena=3.5};
            listaLepsza.Items.Add(student);
            Student lepszyStudent = student.PobierzLepszaWersje();
            listaLepsza.Items.Add(lepszyStudent);

            Samochod auto = new Samochod { Predkosc = 30 };
            listaLepsza.Items.Add(auto.ToString());
            Samochod lepszeAuto = auto.PobierzLepszaWersje();
            listaLepsza.Items.Add(lepszeAuto.ToString());
        }

        private void bntDodaj_Click(object sender, RoutedEventArgs e)
        {
            OknoDodaj okno = new OknoDodaj();
            
            if(okno.ShowDialog() == true)
            {
                Zadanie zadanie = okno.PobraneZadanie;
                kolejkaZadan.Enqueue(zadanie);
            }
        }

        private void bntPobierz_Click(object sender, RoutedEventArgs e)
        {
            if(kolejkaZadan.Count > 0)
            {
                Zadanie zadanie = kolejkaZadan.Dequeue();
                OknoPobierzZadanie okno = new OknoPobierzZadanie(zadanie);
                okno.ShowDialog();
            }
            else
            {
                MessageBox.Show("Brak zadań w kolejce!");
            }
        }
    }
}