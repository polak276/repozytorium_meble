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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;
using System.Threading;
using Meble_v1.Languages;
using Microsoft.Win32;
using System.IO;

namespace Meble_v1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_main_menu_create_new_order_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog new_order_dialog = new SaveFileDialog();
            new_order_dialog.Title = "Create new order"; //jezykowo to zrobic
            new_order_dialog.Filter = "Order file|*.fro";
            new_order_dialog.OverwritePrompt = true;

            if (new_order_dialog.ShowDialog() == true)
            {


                //new_order_dialog.FileName = new_order_dialog.FileName.Substring(0, new_order_dialog.FileName.Length-4);
                System.IO.FileStream order_file = (System.IO.FileStream)new_order_dialog.OpenFile();

                //order_file.Close();

                //po pomyslnym ukonczeniu okna dialogowego
                Tworzenie_nowego_zlecenia new_order = new Tworzenie_nowego_zlecenia(System.IO.Path.GetFileName(order_file.Name) );
                this.Close();
                new_order.ShowDialog();
            }
        }

        private void button_main_menu_wyjscie_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void button_language_selection_Click(object sender, RoutedEventArgs e)
        {
            ustawienie_jezyka ust_jez = new ustawienie_jezyka();
            ust_jez.creatingForm = this;
            ust_jez.ShowDialog();
        }
    }
}
