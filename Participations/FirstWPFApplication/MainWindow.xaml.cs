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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FirstWPFApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //one way
            //lblOutput.Content = "";
            lblOutput.Visibility = Visibility.Hidden;

        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("You clicked me!");

            string dobValue = txtDOB.Text;
            DateTime dob = Convert.ToDateTime(dobValue);

            TimeSpan age = DateTime.Now - dob;

            int years = age.Days / 365;

            lblOutput.Content = $"Hey _______, you are {years.ToString("G0")}";
            lblOutput.Visibility = Visibility.Visible;
        }
    }
}
