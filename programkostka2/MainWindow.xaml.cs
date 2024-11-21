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
        private List<int> wynikirzutu = new List<int>();  //lista 

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

            
            wynikirzutuText.Text = $"Wyniki rzutu: {string.Join(", ", wynikirzutu)}"; //w tym przypadku posłużyłem się internetem
            sumaWyniku.Text = $"Suma wyników: {sumarzutu}"; 

            
            int sumaoczek1 = liczsume1();  
            int sumaoczek2 = liczsume2();  

            sumaogolna += sumaoczek1;  

            
            sumaWyniku.Text = $"Wynik z pierwszego liczenia: {sumaoczek1}";//tu wyświetlają sie wyniki i zrobiłem to sam więc chwała dla mnie
            sumaWyniku2.Text = $"Wynik z zaawansowanego liczenia: {sumaoczek2}";
            sumaOgolem.Text = $"Ogólna suma rzutów: {sumaogolna}";
        }

       
        private void powtorz_Click(object sender, RoutedEventArgs e)
        {
            sumaogolna = 0;
            wynikirzutu.Clear();
            sumaOgolem.Text = "wynik = 0";
            sumaWyniku.Text = "brak";
            sumaWyniku2.Text = "brak";
            wynikirzutuText.Text = "brak";


        }

        
        private int liczsume1()
        {
            int suma = 0;
            foreach (int wynik in wynikirzutu)
            {
                suma += wynik;  // Dodanie każdego wyniku do sumy
            }
            return suma;
        }

        
        private int liczsume2()
        {
            Dictionary<int, int> liczba = new Dictionary<int, int>();  
            int suma = 0;

            
            foreach (int wynik in wynikirzutu)
            {
                if (liczba.ContainsKey(wynik))//nie wiem ale działa
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
                    suma += obie.Key * obie.Value;  //nie mam naprawdę bladego pojęcia o co chodzi z tym ale chyba dzuiała
                }
            }

            return suma;
        }
    }
}