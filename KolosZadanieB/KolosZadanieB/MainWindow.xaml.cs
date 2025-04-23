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

namespace KolosZadanieB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static T JedenZTrzech<T> (T a, T b  , T c)
        {
            Random rnd = new Random();
            int losowanie = rnd.Next(0, 3);
            if(losowanie == 0)
            {
                return a;
            }else if(losowanie == 1)
            {
                return b;
            }
            else
            {
                return c;
            }
        }

        private void btnString_Click(object sender, RoutedEventArgs e)
        {
            string wylosowany = JedenZTrzech<string>("Pierwszy", "Drugi", "Trzeci");
            MessageBox.Show(wylosowany);
        }

        private void btnArmata_Click(object sender, RoutedEventArgs e)
        {
            Armata a = new Armata { Kaliber = 100, Masa = 1000 };
            Armata b = new Armata { Kaliber = 110, Masa = 1200 };
            Armata c = new Armata { Kaliber = 130, Masa = 1500 };
            Armata wylosowana = JedenZTrzech<Armata>(a, b, c);
            MessageBox.Show(wylosowana.ToString());
        }
    }
}