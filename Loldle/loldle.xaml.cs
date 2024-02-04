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
    public partial class loldle : Window
    {
        Game game = new Game();
        public Action OnReset;
        Champion champ = new Champion();
        Champion champion;
        public loldle()
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



            (int check, champ) = game.checkAnswer(inputText, champion);

            if (check == 0)
            {
                MessageBox.Show("Victoire");
                OnReset?.Invoke();
            }
            else if (check == 1)
            {
                ChampionsListView.Items.Insert(0, champ);

            }
            else
            {
                MessageBox.Show("Pas champ");
            }
        }

        private void ChechName(object sender, EventArgs e)
        {
            TextBlock a = (TextBlock)sender;
            a.Background = Brushes.Red;
        }

        private void CheckGender(object sender, EventArgs e)
        {
            TextBlock a = (TextBlock)sender;
            if (champion.Gender.SequenceEqual(champ.Gender))
            {
                a.Background = Brushes.Green;
            }
            else
            {
                a.Background = Brushes.Red;
            }
        }
        private void CheckRole(object sender, EventArgs e)
        {
            TextBlock a = (TextBlock)sender;
            if (champion.Role.Intersect(champ.Role).Any() || champ.Role.Intersect(champion.Role).Any())
            {
                a.Background = Brushes.Orange;
            }
            else
            {
                a.Background = Brushes.Red;
            }
            if (champion.Role.SequenceEqual(champ.Role))
            {
                a.Background = Brushes.Green;
            }

        }

        //verif color
        private void CheckRace(object sender, EventArgs e)
        {
            TextBlock a = (TextBlock)sender;

            if (champion.Race.SequenceEqual(champ.Race))
            {
                a.Background = Brushes.Green;
            }
            else if (champion.Race.Intersect(champ.Race).Any())
            {
                a.Background = Brushes.Orange;
            }
            else
            {
                a.Background = Brushes.Red;
            }
        }

        private void CheckResource(object sender, EventArgs e)
        {
            TextBlock a = (TextBlock)sender;

            if (champion.Gender.SequenceEqual(champ.Gender))
            {
                a.Background = Brushes.Green;
            }
            else if (champion.Resource.Intersect(champ.Resource).Any())
            {
                a.Background = Brushes.Orange;
            }
            else
            {
                a.Background = Brushes.Red;
            }
        }

        private void CheckRangeType(object sender, EventArgs e)
        {
            TextBlock a = (TextBlock)sender;

            if (champion.Range.SequenceEqual(champ.Range))
            {
                a.Background = Brushes.Green;
            }
            else if (champion.Range.Intersect(champ.Range).Any())
            {
                a.Background = Brushes.Orange;
            }
            else
            {
                a.Background = Brushes.Red;
            }
        }

        private void CheckYear(object sender, EventArgs e)
        {
            TextBlock a = (TextBlock)sender;

            if (champion.Date.SequenceEqual(champ.Date))
            {
                a.Background = Brushes.Green;
            }
            else
            {
                a.Background = Brushes.Red;
            }
        }

        private void CheckRegion(object sender, EventArgs e)
        {
            TextBlock a = (TextBlock)sender;

            if (champion.Region.SequenceEqual(champ.Region))
            {
                a.Background = Brushes.Green;
            }
            else if (champion.Region.Intersect(champ.Region).Any())
            {
                a.Background = Brushes.Orange;
            }
            else
            {
                a.Background = Brushes.Red;
            }
        }
    }
}
