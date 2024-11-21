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

namespace programkostka2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int sumaogolna = 0;
        private List<int> wynikirzutu = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void rzut_Click(object sender, RoutedEventArgs e)
        {
            int liczbakostek1 = (int)liczbakostek.Value;
            int liczbascian1 = (int)liczbascian.Value;

            int sumarzutu = 0;
            wynikirzutu.Clear();

            for (int i = 0; i < liczbakostek1; i++)
            {
                int wynik = new Random().Next(1, liczbascian1 + 1);
                wynikirzutu.Add(wynik);
                sumarzutu += wynik;

                wynikirzutu.Text = $"Wynik ogólny: {sumarzutu}";
            }
        }
        private void powtorz_Click(object sender, RoutedEventArgs e)
        {
            sumaogolna = 0;
            
        }
    }
}