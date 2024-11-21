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

                
            }
            wynikirzutu.Text = $"Wynik ogólny: {sumarzutu}";
            int sumaoczek1 = liczsume1();
            int sumaoczek2 = liczsume2();

            sumaogolna += sumaoczek1;

            sumaWyniku.Text = $"wynik z pierwszego liczenia: {sumaoczek1}";
            sumaWyniku2.Text = $"wynik z liczenia zaawansowanego: {sumaoczek2}";
        }
        private void powtorz_Click(object sender, RoutedEventArgs e)
        {
            sumaogolna = 0;

            
        }
        private int liczsume1()
        {
            int suma = 0;
            foreach (int wynik in wynikirzutu)
            {
                suma += wynik;
            }
            return suma;
        }
        private int liczsume2()
        {
            Dictionary<int, int> liczba = new Dictionary<int, int>();
            int suma = 0;

            foreach (int wynik in wynikirzutu)
            {
                if (liczba.ContainsKey(wynik))
                {
                    liczba[wynik]++;
                }
                else
                {
                    liczba[wynik] = 1;
                }
            }
            foreach (var obie in liczba)
            {
                if (obie.Value >= 2)
                {
                    suma += obie.Key * obie.Value;
                }
            }
        }
    }
}