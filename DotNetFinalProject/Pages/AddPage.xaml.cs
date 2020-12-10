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

namespace DotNetFinalProject.Pages
{
    /// <summary>
    /// Interaction logic for AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        public AddPage()
        {
            InitializeComponent();
        }

        private void Add_Contact(object sender, RoutedEventArgs e)
        {
            if (Create_FirstName.Text.Equals(string.Empty) || Create_LastName.Text.Equals(string.Empty) || Create_Email.Text.Equals(string.Empty) || Create_PhoneNumber.Text.Equals(string.Empty))
            {
                MessageBox.Show("You are missing a field!", "Error!", MessageBoxButton.OK);
            }
            else
            {
                Contact contact = new Contact(Create_FirstName.Text, Create_LastName.Text, Create_Email.Text, Create_PhoneNumber.Text);

            }
        }
    }
}
