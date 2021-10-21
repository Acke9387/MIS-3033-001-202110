using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace JSON_Serialization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Game> AllGames = new List<Game>();
        public MainWindow()
        {
            InitializeComponent();

            string[] linesOfFile = File.ReadAllLines("all_games.csv");
            cboPlatforms.Items.Add("All");
            for (int i = 1; i < linesOfFile.Length; i++)
            {
                //0         1           2           3        4          5
                //name platform    release_date summary meta_score user_review
                string[] pieces = linesOfFile[i].Split(",");
                Game g = new Game()
                {
                    name = pieces[0].Trim(),
                    platform = pieces[1].Trim(),
                    release_date = Convert.ToDateTime(pieces[2].Trim()),
                    summary = pieces[3].Trim(),
                    meta_score = Convert.ToInt32(pieces[4]),
                    user_review = pieces[5]
                };

                if (cboPlatforms.Items.Contains(g.platform) == false)
                {
                    cboPlatforms.Items.Add(g.platform); 
                }

                lstGames.Items.Add(g);
                AllGames.Add(g);
            }

            lblCount.Content = $"Record Count : {lstGames.Items.Count.ToString("N0")}";
        }

        private void cboPlatforms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //string platform = cboPlatforms.SelectedItem.ToString();
            string platform = (string)cboPlatforms.SelectedItem;
            lstGames.Items.Clear();
            foreach (var game in AllGames)
            {
                if (platform == "All")
                {
                    lstGames.Items.Add(game);
                }
                else if (game.platform == platform)
                {
                    lstGames.Items.Add(game);
                }

            }

            lblCount.Content = $"Record Count : {lstGames.Items.Count.ToString("N0")}";

        }

        private void lstGames_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Game selected = (Game)lstGames.SelectedItem;

            DetailsWindow deets = new DetailsWindow();

            deets.PopulateData(selected);

            deets.ShowDialog();

        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            string json = JsonConvert.SerializeObject(lstGames.Items, Formatting.Indented);

            File.WriteAllText($"{(string)cboPlatforms.SelectedItem}_games.json", json);

            MessageBox.Show("Saved contents of listbox successfully!");
        }
    }
}
