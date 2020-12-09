using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace DotNetFinalProject
{
    /// <summary>
    /// Interaction logic for deleteContact.xaml
    /// </summary>
    public partial class deleteContact : Window
    {

        String textIn;

        public deleteContact()
        {
            InitializeComponent();
        }
        private void MyTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
             textIn = MyTextBox.Text;
        }
        private void DeleteContact_Click(object sender, RoutedEventArgs e)
        {
            //Make it in a method of its own?
            //Add connection String
            var connection = new SqlConnection("YourDatabaseConnectionString");

            Console.WriteLine("Which Contact do you want to delete? (Use his/her ID)");
            textIn = Console.ReadLine();

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Contact WHERE ContactID = @ContactID", connection);
                cmd.Parameters.AddWithValue("@ContactID", textIn);

                cmd.ExecuteNonQuery();

                connection.Close();
            }

            catch (SystemException ex) //Or just exception?
            {
                MessageBox.Show(string.Format("An error occurred: No rows were deleted", ex.Message));
            }
            //finally
            //{

            //}
        }

        private void DeleteGoBck_Click(object sender, RoutedEventArgs e)
        {
          
        }
    }
}
