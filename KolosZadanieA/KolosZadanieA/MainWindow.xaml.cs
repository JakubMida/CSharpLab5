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

namespace KolosZadanieA
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

        private void btnPudelko_Click(object sender, RoutedEventArgs e)
        {
            listaPudelko.Items.Clear();
            try
            {
                Pudelko<string> pudelko = new Pudelko<string>(10);
                pudelko.Wloz("Pierwszy", 0);
                pudelko.Wloz("Drugi", 2);
                pudelko.Wloz("Trzeci", 5);

                listaPudelko.Items.Add(pudelko.Wyciagnij(0));
                listaPudelko.Items.Add(pudelko.Wyciagnij(2));
                listaPudelko.Items.Add(pudelko.Wyciagnij(5));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}