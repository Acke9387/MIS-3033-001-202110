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

namespace WPF_with_class_review
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //lstNumbers.Items.Add(5);
            //lstWords.Items.Add("Hello world");
            txtInput.Clear();
            txtInput.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

            string input = txtInput.Text;
            double convertedValue;
            bool isNumber = double.TryParse(input, out convertedValue);

            if (isNumber)
            {
                lstNumbers.Items.Add(convertedValue.ToString("N3"));
            }
            else
            {
                lstWords.Items.Add(input);
            }
            txtInput.Clear();
        }
    }
}
