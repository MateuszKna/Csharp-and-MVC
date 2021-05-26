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

namespace KalkulatorLab7
{

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        double zmiennaPierwsza = 0;
        double zmiennaDruga = 0;
        double wynik;
        char dzialanie = ' ';

        private void Bc_Click(object sender, RoutedEventArgs e)
        {
            pwynik.Text = "0";
        }

        private void Bpot_Click(object sender, RoutedEventArgs e)
        {
            zmiennaPierwsza = Convert.ToDouble(pwynik.Text); 
            wynik = zmiennaPierwsza * zmiennaPierwsza;
            pwynik.Text = wynik.ToString();
        }

        private void Bpier_Click(object sender, RoutedEventArgs e)
        {
            zmiennaPierwsza = Convert.ToDouble(pwynik.Text);
            wynik = Math.Sqrt(zmiennaPierwsza);
            pwynik.Text = wynik.ToString();
        }

        private void Bdz_Click(object sender, RoutedEventArgs e)
        {
            dzialanie = '/';
            zmiennaPierwsza = Convert.ToDouble(pwynik.Text);
            pwynik.Text = zmiennaPierwsza.ToString() + " / ";
            pwynik.Text = "";
        }

        private void Bmno_Click(object sender, RoutedEventArgs e)
        {
            dzialanie = '*';
            zmiennaPierwsza = Convert.ToDouble(pwynik.Text);
            pwynik.Text = zmiennaPierwsza.ToString() + " * ";
            pwynik.Text = "";

        }

        private void Bminus_Click(object sender, RoutedEventArgs e)
        {
            dzialanie = '-';
            zmiennaPierwsza = Convert.ToDouble(pwynik.Text);
            pwynik.Text = zmiennaPierwsza.ToString() + " - ";
            pwynik.Text = "";

        }

        private void Bplus_Click(object sender, RoutedEventArgs e)
        {
            dzialanie = '+';
            zmiennaPierwsza = Convert.ToDouble(pwynik.Text);
            pwynik.Text = zmiennaPierwsza.ToString() + " + ";
            pwynik.Text = "";

        }

        private void Bprze_Click(object sender, RoutedEventArgs e)
        {
            if (!pwynik.Text.Contains(","))
            {
                pwynik.Text += ",";
            }
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            if (pwynik.Text == "0")
            {
                pwynik.Clear();
            }
            //pwynik.Text += '1';
            Obliczenia(1);

        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            if (pwynik.Text == "0")
            {
                pwynik.Clear();
            }
            //pwynik.Text += '2';
            Obliczenia(2);
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            if (pwynik.Text == "0")
            {
                pwynik.Clear();
            }
           // pwynik.Text += '3';
            Obliczenia(3);
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            if (pwynik.Text == "0")
            {
                pwynik.Clear();
            }
            //pwynik.Text += '4';
            Obliczenia(4);
        }

        private void B5_Click(object sender, RoutedEventArgs e)
        {
            if (pwynik.Text == "0")
            {
                pwynik.Clear();
            }
            //pwynik.Text += '5';
            Obliczenia(5);
        }

        private void B6_Click(object sender, RoutedEventArgs e)
        {
            if (pwynik.Text == "0")
            {
                pwynik.Clear();
            }
            //pwynik.Text += '6';
            Obliczenia(6);
        }

        private void B7_Click(object sender, RoutedEventArgs e)
        {
            if (pwynik.Text == "0")
            {
                pwynik.Clear();
            }
            //pwynik.Text += '7';
            Obliczenia(7);
        }

        private void B8_Click(object sender, RoutedEventArgs e)
        {
            if (pwynik.Text == "0")
            {
                pwynik.Clear();
            }
            //pwynik.Text += '8';
            Obliczenia(8);
        }

        private void B9_Click(object sender, RoutedEventArgs e)
        {
            if (pwynik.Text == "0")
            {
                pwynik.Clear();
            }
            //pwynik.Text += '9';
            Obliczenia(9);
        }


        private void B0_Click(object sender, RoutedEventArgs e)
        {
            if (pwynik.Text == "0")
            {
                pwynik.Clear();
            }
            //pwynik.Text += '0';
            Obliczenia(0);
        }

        private void Obliczenia(double z1)
        {
            
            if (dzialanie == ' ')
            {
                pwynik.Text += z1;
                zmiennaPierwsza = Convert.ToDouble(pwynik.Text);
                    pwynik.Text = zmiennaPierwsza.ToString();

            }
            else
            {
               // pwynik.Text = ""; Chcialem zachowac wypisywanie wszystkich liczb ale niestety musze "czyscic" pwynik.Text
                pwynik.Text += z1;
                    zmiennaDruga = Convert.ToDouble(pwynik.Text);
                    pwynik.Text = zmiennaDruga.ToString();

                
               
                    
               
                
                
            }

        }

        private void Bwynik_Click(object sender, RoutedEventArgs e)
        {
   
            switch (dzialanie)
            {
                case('/'):
                    if (zmiennaDruga != 0)
                    {
                        wynik = zmiennaPierwsza / zmiennaDruga;
                        pwynik.Text = wynik.ToString();
                    }
                    else
                    {
                        pwynik.Text = "Nie wolno";
                    }
                    break;
                case ('*'):
                    wynik = zmiennaPierwsza * zmiennaDruga;
                    pwynik.Text = wynik.ToString();
                    break;
                case ('-'):
                    wynik = zmiennaPierwsza - zmiennaDruga;
                    pwynik.Text = wynik.ToString();
                    break;
                case ('+'):
                    wynik = zmiennaPierwsza + zmiennaDruga;
                    pwynik.Text = zmiennaPierwsza.ToString() + " + ";
                    pwynik.Text = wynik.ToString();
                    break;
            }
            zmiennaPierwsza = 0;
            zmiennaDruga = 0;
            dzialanie = ' ';

          
        }



    }
}
