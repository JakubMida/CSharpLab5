using Klasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab5ZadanieDomowe
{
    /// <summary>
    /// Logika interakcji dla klasy OknoDodaj.xaml
    /// </summary>
    public partial class OknoDodaj : Window
    {
        public Zadanie PobraneZadanie { get; set; }
        public OknoDodaj()
        {
            InitializeComponent();
        }

        private void bntOk_Click(object sender, RoutedEventArgs e)
        {
            string opisZadania = txtPolecenie.Text;
            if (!string.IsNullOrEmpty(opisZadania))
            {
                PobraneZadanie = new Zadanie(opisZadania);
                this.Close();
            }
            else
            {
                MessageBox.Show("Opis zadania nie może być pusty!");
            }
        }
    }
}
