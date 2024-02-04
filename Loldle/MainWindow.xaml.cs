using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Loldle
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            liste liste = new liste();
            liste.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            loldle loldle = new loldle();
            loldle.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            emoji emoji = new emoji();
            emoji.Show();
        }
    }
}