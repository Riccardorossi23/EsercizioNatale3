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

namespace EsercizioNatale3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TextBox[] array;
        public MainWindow()
        {
            InitializeComponent();
            array = new TextBox[] { txtnum1, txtnum2, txtnum3, txtnum4, txtnum5, txtnum6 };
        }

        private void btnON_Checked(object sender, RoutedEventArgs e)
        {
            if (btnON.Content.ToString() == "ON")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i].IsEnabled = true;
                }
                btnCalcola.IsEnabled = true;
                btnON.Content = "OFF";
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i].IsEnabled = false;
                }
                btnCalcola.IsEnabled = false;
                btnON.Content = "ON";
            }

        }

        private void btnCalcola_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int pari = 0;
                int dispari = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    int num = int.Parse(array[i].Text);
                    if (num % 2 == 0)
                    {
                        pari++;
                    }
                    else
                    {
                        dispari++;
                    }
                }
                lblRisultato.Content = $"I numeri pari sono {pari}, i numeri dispari sono {dispari}";
            }
            catch
            {
                MessageBox.Show("Inserire solo numeri");
            }

        }
    }
}