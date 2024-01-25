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
        Game game = new Game();
        public Action OnReset;
        public MainWindow()
        {
            InitializeComponent();

            OnReset += HandleReset;
            OnReset?.Invoke();   

        }
        public void HandleReset()
        {
            var champion = game.Start();
            test.Text = champion.Name;
        }

        private void Reset(object sender, RoutedEventArgs e)
        {
            OnReset?.Invoke();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            string inputText = TextBoxInput.Text;
            MessageBox.Show(inputText);
        }
    }
}