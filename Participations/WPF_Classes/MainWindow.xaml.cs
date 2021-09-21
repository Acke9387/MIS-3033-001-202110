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

namespace WPF_Classes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            bool inputIsValid = true;

            if (string.IsNullOrWhiteSpace(txtImage.Text) == true)
            {
                inputIsValid = false;
                MessageBox.Show("Please input a valid response for image");
            }

            if (string.IsNullOrWhiteSpace(txtManufacturer.Text) == true)
            {
                inputIsValid = false;
                MessageBox.Show("Please input a valid response for manufacturer");
            }

            if (string.IsNullOrWhiteSpace(txtName.Text) == true)
            {
                inputIsValid = false;
                MessageBox.Show("Please input a valid response for name");
            }

            double price;

            if (double.TryParse(txtPrice.Text, out price) == false)
            {
                inputIsValid = false;
                MessageBox.Show("Please input a valid response for price");
            }

            if (inputIsValid == false)
            {
                return;
            }

            Toy t = new Toy();
            t.Image = txtImage.Text;
            t.Manufacturer = txtManufacturer.Text;
            t.Name = txtName.Text;
            t.Price = price;

            lstToys.Items.Add(t);

        }

        private void lstToys_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Toy selectedToy = (Toy)lstToys.SelectedItem;
            MessageBox.Show(selectedToy.GetAisle());

            var uri = new Uri(selectedToy.Image);
            var img = new BitmapImage(uri);
            imgToy.Source = img;
        }
    }
}
