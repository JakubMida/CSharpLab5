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
    /// Logika interakcji dla klasy OknoPobierzZadanie.xaml
    /// </summary>
    public partial class OknoPobierzZadanie : Window
    {
        public OknoPobierzZadanie(Zadanie zadanie)
        {
            InitializeComponent();
            lblOpisZadania.Content = zadanie;
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
