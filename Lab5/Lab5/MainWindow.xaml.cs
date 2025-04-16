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

namespace Lab5
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

        private void btnZadanieA_Click(object sender, RoutedEventArgs e)
        {
            Stozek stozek = new Stozek();
            
            stozek.Blad += PokazMessageBox;
            stozek.Blad += WypelnijLabel;

            try
            {
                double r, h;
                r = Convert.ToDouble(txtPromien.Text);
                h = Convert.ToDouble(txtWysokosc.Text);

                stozek.Promien = r;
                stozek.Wysokosc = h;
            }
            catch
            {
                MessageBox.Show("Błedny format danych!");
            }
            
        }

        public void PokazMessageBox(string opis)
        {
            MessageBox.Show(opis);
        }

        public void WypelnijLabel(string opis)
        {
            lblBlad.Content = opis;
        }
    }
}