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
using Meble_v_1.Zamowienie;
using Meble_v1.Languages;

namespace Meble_v1
{
    /// <summary>
    /// Logika interakcji dla klasy Tworzenie_nowego_zlecenia.xaml
    /// </summary>
    public partial class Tworzenie_nowego_zlecenia : Window
    {
        private Zamowienie nowe_zamowienie;

        public Tworzenie_nowego_zlecenia(string nazwa)
        {
            InitializeComponent();
            nowe_zamowienie = new Zamowienie(nazwa);
        }

        public Tworzenie_nowego_zlecenia( )
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
            this.Close();
            mainwindow.ShowDialog();
        }

        private void button_cno_add_cupboard_Click(object sender, RoutedEventArgs e)
        {
            Wybieranie_szafek new_cupboard = new Wybieranie_szafek(nowe_zamowienie);
            this.Close();
            new_cupboard.ShowDialog();
        }
    }
}
