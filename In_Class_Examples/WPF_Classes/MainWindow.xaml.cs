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
            string id, first, last, probation, gpa, bursar;

            id = txtSoonerID.Text;
            first = txtFirst.Text;
            last = txtLast.Text;
            //probation = txtProbation.Text;
            gpa = txtGPA.Text;
            bursar = txtBursar.Text;

            Student stud = new Student(Convert.ToInt32(id), first, last, Convert.ToDouble(bursar));
            stud.GPA = Convert.ToDouble(gpa);
            stud.IsOnProbation = chkProbation.IsChecked.Value;
            //if (probation.ToLower() == "yes")
            //{
            //    stud.IsOnProbation = true;
            //}
            //else
            //{
            //    stud.IsOnProbation = false;
            //}

            lstStudents.Items.Add(stud);

        }

        private void lstStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Student selectedStudent = (Student) lstStudents.SelectedItem;
            MessageBox.Show($"{selectedStudent.ToString()} has a Bursar Balance of {selectedStudent.CheckBalance().ToString("C")}");
            //if (lstStudents.SelectedItem is Student)
            //{

            //}
        }
    }
}
