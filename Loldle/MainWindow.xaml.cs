using System.Diagnostics;
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

namespace Loldle
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var reader = new Reader();

            var championCollection = reader.Json();

            Debug.WriteLine(championCollection.Champions);

            Debug.WriteLine("UwU");

            test.Text = championCollection.Champions["Aatrox"].Name;

        }
    }
}