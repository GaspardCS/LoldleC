using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using static System.Net.Mime.MediaTypeNames;

namespace Loldle
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        Game game = new Game();
        public Action OnReset;
        EmojiChamp champChecked = new EmojiChamp();
        EmojiChamp emochamp = new EmojiChamp();

        public Window1()
        {
            InitializeComponent();
            Input.Text = "";
            OnReset += HandleReset;
            OnReset?.Invoke();

        }

        public void HandleReset()
        {
            emochamp = game.StartEmoji();
            testname.Text = emochamp.Emojis;
            ChampionsListView.Items.Clear();
        }
        private void Reset(object sender, RoutedEventArgs e)
        {
            OnReset?.Invoke();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            string inputText = Input.Text;
            (int check, champChecked) = game.checkEmojiAnswer(inputText, emochamp);

            if (check == 0)
            {
                MessageBox.Show("Victoire");
                OnReset?.Invoke();
            }
            else if (check == 1)
            {
                ChampionsListView.Items.Insert(0, champChecked);
            }
            else
            {
                MessageBox.Show("Pas champ");
            }
        }
    }
}
