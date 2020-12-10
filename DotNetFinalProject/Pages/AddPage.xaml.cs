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
            if (Create_FirstName.Text.Equals(string.Empty)|| Create_LastName.Text.Equals(string.Empty)|| Create_Email.Text.Equals(string.Empty)|| Create_PhoneNumber.Text.Equals(string.Empty))
            {
                MessageBox.Show("You are missing a field!", "Error!", MessageBoxButton.OK);
            }
            else
            {
                Contact contact = new Contact
                {
                    fn = Create_FirstName.Text,
                    ln = Create_LastName.Text,
                    email = Create_Email.Text,
                    phone = Create_PhoneNumber.Text
                };

                MessageBox.Show(contact.fn, "Success!", MessageBoxButton.OK);
                Create(contact);

                MessageBox.Show("Your contact has been added to ", "Success!", MessageBoxButton.OK);
            }
        }

        public int Create(Contact contact)
        {
            var con = new SqlConnection(@"data source=DESKTOP-K72MI89\SQLEXPRESS2;database = Contact;Trusted_Connection=True");

            SqlCommand cm = new SqlCommand("insert into contact(FirstName, LastName, Email, PhoneNumber) values(@FirstName, @LastName, @Email, @PhoneNumber)", con);

            cm.Parameters.AddWithValue("@FirstName", contact.fn);
            cm.Parameters.AddWithValue("@LastName", contact.ln);
            cm.Parameters.AddWithValue("@Email", contact.email);
            cm.Parameters.AddWithValue("@PhoneNumber", contact.phone);

            int newId = 0;
            try
            {
                con.Open();
                cm.ExecuteNonQuery();
                string query2 = "Select @@Identity as newId from contact";
                cm.CommandText = query2;
                cm.Connection = con;
                newId = Convert.ToInt32(cm.ExecuteScalar());
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error inserting data");
            }
            finally
            {
                con.Close();
            }

            return newId;
        }
    }
}
