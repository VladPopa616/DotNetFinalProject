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
        SQLCommunications sql = SQLCommunications.Instance;
        public UpdatePage()
        {
            InitializeComponent();
        }

        


        private void ConfirmUpdateClick(object sender, RoutedEventArgs e)
        {
            Contact contact = new Contact(Id.Content, FnInput.Text, LnInput.Text, emailInput.Text, phoneInput.Text);

            contact.fn = FnInput.Text.ToString();
            contact.ln = LnInput.Text.ToString();
            contact.email = emailInput.Text.ToString();
            contact.phone = phoneInput.Text.ToString();

            sql.UpdateContacts(contact);
        }


    }
}
