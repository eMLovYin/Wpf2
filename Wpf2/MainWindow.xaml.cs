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

namespace Wpf2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller controller;

        public MainWindow()
        {
            controller = Controller.GetInstance();
            InitializeComponent();
        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            controller.AddPerson(FirstName.Text, LastName.Text, Age.Text, Phone.Text);

            PC.Content = controller.PersonCount;
            Index.Content = controller.PersonIndex;

            FirstName.Text = "";
            LastName.Text = "";
            Age.Text = "";
            Phone.Text = "";
        }

        private void Delete_Click_1(object sender, RoutedEventArgs e)
        {
            controller.DeletePerson();

            PC.Content = controller.PersonCount;
            Index.Content = controller.PersonIndex;

            if (controller.CurrentPerson != null)
            {
                FirstName.Text = controller.CurrentPerson.FirstName;
                LastName.Text = controller.CurrentPerson.LastName;
                Age.Text = Convert.ToString(controller.CurrentPerson.Age);
                Phone.Text = controller.CurrentPerson.PhoneNumber;
            }
            else
            {
                FirstName.Text = "";
                LastName.Text = "";
                Age.Text = "";
                Phone.Text = "";
            }

        }

        private void Up_Click(object sender, RoutedEventArgs e)
        {
            controller.NextPerson();

            Index.Content = controller.PersonIndex;

            FirstName.Text = controller.CurrentPerson.FirstName;
            LastName.Text = controller.CurrentPerson.LastName;
            Age.Text = Convert.ToString(controller.CurrentPerson.Age);
            Phone.Text = controller.CurrentPerson.PhoneNumber;
        }

        private void Down_Click(object sender, RoutedEventArgs e)
        {
            controller.PreviousPerson();

            Index.Content = controller.PersonIndex;

            FirstName.Text = controller.CurrentPerson.FirstName;
            LastName.Text = controller.CurrentPerson.LastName;
            Age.Text = Convert.ToString(controller.CurrentPerson.Age);
            Phone.Text = controller.CurrentPerson.PhoneNumber;
        }
    }
}
