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

        Champion champion;
        public MainWindow()
        {
            InitializeComponent();

            OnReset += HandleReset;
            OnReset?.Invoke();   

        }
        public void HandleReset()
        {
            champion = game.Start();
            test.Text = champion.Name;
            ChampionsListView.Items.Clear();
        }

        private void Reset(object sender, RoutedEventArgs e)
        {
            OnReset?.Invoke();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            string inputText = TextBoxInput.Text;

            Champion champ = new Champion();


            (int check, champ)  = game.checkAnswer(inputText, champion);

            if (check == 0)
            {
                MessageBox.Show("Victoire");
                OnReset?.Invoke();
            }
            else if (check == 1)
            {
                ChampionsListView.Items.Insert(0,champ);

            }
            else
            {
                MessageBox.Show("Pas champ");
            }   
        }
    }
}