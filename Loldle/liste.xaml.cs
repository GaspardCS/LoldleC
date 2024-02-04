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
using System.Windows.Shapes;

namespace Loldle
{

    public partial class liste : Window
    {
        private string[] allName;
        private List<string> championsFound = new List<string>();

        public liste()
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
        }
    }
}
