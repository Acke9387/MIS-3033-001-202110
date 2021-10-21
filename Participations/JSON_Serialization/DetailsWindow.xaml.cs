using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace JSON_Serialization
{
    /// <summary>
    /// Interaction logic for DetailsWindow.xaml
    /// </summary>
    public partial class DetailsWindow : Window
    {
        public DetailsWindow()
        {
            InitializeComponent();
        }

        public void PopulateData(Game game)
        {
            txtName.Text = game.name;
            txtMetaScore.Text = game.meta_score.ToString();
            txtPlatform.Text = game.platform;
            txtReleaseDate.Text = game.release_date.ToShortDateString();
            txtSummary.Text = game.summary;
            txtUserReview.Text = game.user_review;

            Title = $"{game.name}'s Details";
        }
    }
}
