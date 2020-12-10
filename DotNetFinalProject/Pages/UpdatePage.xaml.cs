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
    /// Interaction logic for UpdatePage.xaml
    /// </summary>
    public partial class UpdatePage : Page
    {
        string input;
        public UpdatePage()
        {
            InitializeComponent();
        }

        private void MyTextBox_Change (object sender, TextChangedEventArgs e)
        {
            input = MyTextBox.Text;
        }


        private void UpdateContact_Click (object sender, RoutedEventArgs e)
        {
            //1. Take the text input

            //2. Message Box pops up
            MessageBox.Show( "First name: " + TextBox)
            //3. Enter fields, if empty keep to default.
            
            //4. Save fields
        }


    }
}
