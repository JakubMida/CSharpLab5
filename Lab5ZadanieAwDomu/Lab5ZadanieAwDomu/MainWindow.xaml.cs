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
using Figury;

namespace Lab5ZadanieAwDomu
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
            stozek.Blad += PokazBladNaLabel;
            stozek.Blad += PokazBladNaBoxie;

            try
            {
                double promien = Convert.ToDouble(txtPromien.Text);
                double wysokosc = Convert.ToDouble(txtWysokosc.Text);

                
                stozek.Promien = promien;
                stozek.Wysokosc = wysokosc;

            }
            catch
            {
                MessageBox.Show("Niepoprawny format danych!");
            }
        }

        private void PokazBladNaLabel(string blad)
        {
            lblBlad.Content = blad;
        }

        private void PokazBladNaBoxie(string blad)
        {
            MessageBox.Show(blad);
        }
    }
}