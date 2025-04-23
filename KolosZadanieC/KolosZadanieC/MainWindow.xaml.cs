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

namespace KolosZadanieC
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

        private void btnOgraniczonyStos_Click(object sender, RoutedEventArgs e)
        {
            listStos.Items.Clear();
            OgraniczonyStos<int> stos = new OgraniczonyStos<int>(5);
            try
            {
                stos.Dodaj(10);
                stos.Dodaj(20);
                stos.Dodaj(30);

                while (!stos.CzyPusty())
                {
                    int wartosc = stos.Pobierz();
                    listStos.Items.Add(wartosc);
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    
    }
}