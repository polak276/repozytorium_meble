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
using Meble_v1.Languages;
using System.Globalization;
using System.Threading;

namespace Meble_v1
{
    /// <summary>
    /// Logika interakcji dla klasy ustawienie_jezyka.xaml
    /// </summary>
    public partial class ustawienie_jezyka : Window
    {

        public ustawienie_jezyka()
        {
            InitializeComponent();

            //ustawic zaznaczenie na takie jaki jest jezyk
            CultureInfo currentUICulture = Thread.CurrentThread.CurrentUICulture;


            if (currentUICulture.Name == "pl-PL")
            {
                radio_button_polski.IsChecked = true;
                radio_button_angielski.IsChecked = false;
            }
            else if (currentUICulture.Name == "en-US")
            {
                radio_button_polski.IsChecked = false;
                radio_button_angielski.IsChecked = true;
            }
        }

        public Window creatingForm
        {
            get;
            set;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (radio_button_polski.IsChecked == true)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("pl-PL");
                creatingForm.Close();
                MainWindow mainwindow = new MainWindow();
                Close();
                mainwindow.ShowDialog();
            }
            if (radio_button_angielski.IsChecked == true)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                creatingForm.Close();
                MainWindow mainwindow = new MainWindow();
                Close();
                mainwindow.ShowDialog();
            }


        }
    }
}
