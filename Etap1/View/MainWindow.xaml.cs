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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace View
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Button is Clicked");
            /*
            Label testLabel = new Label();
            testLabel.Content = "TEST";
            this.Granice.Child = testLabel;
            */

            int ilosc = Int32.Parse(this.Ilosc.Text);

            Kolko kolko = new Kolko();
            kolko.Promien = 5;
            kolko.Rysuj(this.Granice, ilosc);
        }
    }
}
