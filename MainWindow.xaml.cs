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

namespace egzamin_WPF
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

        private void checkCena_Click(object sender, RoutedEventArgs e)
        {
            bool pocz = pocztowka.IsChecked == true;
            bool li = list.IsChecked == true;
            bool pacz = paczka.IsChecked == true;

            if (pocz)
            {
                cenaShow.Content = "Cena: 1 zł";
                zdjecie.Source = new BitmapImage(new Uri("pocztowka.png", UriKind.Relative));
            }
            else if (li)
            {
                cenaShow.Content = "Cena: 1.5 zł";
                zdjecie.Source = new BitmapImage(new Uri("list.png", UriKind.Relative));
            }
            else if (pacz)
            {
                cenaShow.Content = "Cena: 10 zł";
                zdjecie.Source = new BitmapImage(new Uri("paczka.png", UriKind.Relative));
            }
            
        }

        private void zatwierdz_Click(object sender, RoutedEventArgs e)
        {
            int kodP = 0;
            bool wynik = int.TryParse(kodPocztowy.Text,out kodP);
            
            if(kodPocztowy.Text.Length != 5)
            {
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym");
            }
            
            else if(!wynik)
            {
                MessageBox.Show("Kod pocztowy powinien składać się z samych liczb!");
            }

            else if(wynik && kodPocztowy.Text.Length == 5)
            {
                MessageBox.Show("Dane przesyłki zostały wprowadzone");
            }

        }
    }
}
