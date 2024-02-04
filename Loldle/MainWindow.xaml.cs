using System.Linq;
using System.Windows;

namespace Loldle
{
    public partial class MainWindow : Window
    {
        private string[] allName;
        private List<string> championsFound = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            Game game = new Game();
            allName = game.allName();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            string inputText = TextBoxInput.Text.ToLower();

            if (allName.Contains(inputText) && !championsFound.Contains(inputText))
            {
                championsFound.Add(inputText);
                ChampionsListView.Items.Add(new { Name = inputText });

                if (championsFound.Count == allName.Length)
                {
                    MessageBox.Show("Victoire! Tous les champions ont été trouvés.");
                }
            }
            else
            {
                // Gérer le cas où l'entrée n'est pas valide ou déjà trouvée
            }
        }
    }

}