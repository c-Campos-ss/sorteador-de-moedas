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

namespace SorteadorDeMoeda
{
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        int chance;
        double porcentagemCara;
        double porcentagemCoroa;
        double totalSorteios;
        int totalCara;
        int totalCoroa;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSorteio(object sender, RoutedEventArgs e) {
            totalSorteios++;
            txtCaraOuCoroa.Visibility = Visibility.Visible;
            chance = rnd.Next(1, 3);
            if (chance == 1) {
                totalCara++;
                imgCoroa.Visibility = Visibility.Hidden;
                imgCara.Visibility = Visibility.Visible;
                txtCaraOuCoroa.Text = "CARA";
                
            }
            else {
                totalCoroa++;
                imgCara.Visibility = Visibility.Hidden;
                imgCoroa.Visibility = Visibility.Visible;
                txtCaraOuCoroa.Text = "COROA";
            }
            porcentagemCara = (totalCara / totalSorteios) * 100;
            porcentagemCara = Math.Round(porcentagemCara, 2);
            txtPorcentagemCara.Text = $"{porcentagemCara}";
            porcentagemCoroa = (totalCoroa / totalSorteios) * 100;
            porcentagemCoroa = Math.Round(porcentagemCoroa, 2);
            txtPorcentagemCoroa.Text = $"{porcentagemCoroa}";
            txtQtdDeSorteios.Text = $"{totalSorteios}";
        }
    }
}

