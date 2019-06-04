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

namespace WpfApplication7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<List<int>> balans;
        int b_dub, b_lipa, b_klen = 0;
        int grivnya = 5000;
        public MainWindow()
        {
            InitializeComponent();
            balans = new List<List<int>>();
        }

        private void click_obm(object sender, RoutedEventArgs e)
        {
            if (b_dub > 0)
            {
                b_dub -= int.Parse(tbKolvo.Text);
                b_lipa += int.Parse(tbKolvo2.Text);
                ttDub.Text = b_dub.ToString();
                ttLipa.Text = b_lipa.ToString();
            }
        }

        private void tbKolvo_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (rbDub.IsChecked == true)
            {
                if (rbLipa1.IsChecked == true)
                {
                    int n = int.Parse(tbKolvo.Text);
                    n = int.Parse(tbKolvo.Text) * 4;
                    tbKolvo2.Text = n.ToString();
                   
                }
            }
        }

        private void tbKolPok_TextChanged(object sender, TextChangedEventArgs e)
        {
            int k = int.Parse(tbKolPok.Text);
            if (rbDub2.IsChecked==true)
            {
                k = int.Parse(tbKolPok.Text)*8;
                tblCoin.Text = k.ToString();
            }
            if (rbLipa2.IsChecked == true)
            {
                k = int.Parse(tbKolPok.Text) * 4;
                tblCoin.Text = k.ToString();
            }
            if (rbKlen2.IsChecked == true)
            {
                k = int.Parse(tbKolPok.Text) * 6;
                tblCoin.Text = k.ToString();
            }
        }

        private void bBuy_Click(object sender, RoutedEventArgs e)
        {
            int k = int.Parse(tbKolPok.Text);
            if (rbDub2.IsChecked == true)
            {
                if (grivnya > 0)
                {
                    
                    k = int.Parse(tbKolPok.Text) * 8;
                    grivnya -= k;
                    b_dub += int.Parse(tbKolPok.Text);
                    ttDub.Text = b_dub.ToString();
                    tblBalans.Text += b_dub.ToString();
                }
            }
            if(rbLipa2.IsChecked==true)
            {
                if (grivnya > 0)
                {
                    //int k = int.Parse(tbKolPok.Text);
                    k = int.Parse(tbKolPok.Text) * 4;
                    grivnya -= k;
                    b_lipa += int.Parse(tbKolPok.Text);
                    ttLipa.Text = b_lipa.ToString();
                    tblBalans.Text += b_lipa.ToString();
                }
            }
            if (rbKlen2.IsChecked == true)
            {
                if (grivnya > 0)
                {
                   // int k = int.Parse(tbKolPok.Text);
                    k = int.Parse(tbKolPok.Text) * 6;
                    grivnya -= k;
                    b_klen += int.Parse(tbKolPok.Text);
                    ttLipa.Text = b_klen.ToString();
                    tblBalans.Text += b_klen.ToString();
                }
            }
            tbKolPok.Clear();
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void tbKolvo2_TextChanged(object sender, TextChangedEventArgs e)
        {
           

        }
    }
}
