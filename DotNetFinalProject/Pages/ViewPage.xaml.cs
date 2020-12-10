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
    /// Interaction logic for ViewPage.xaml
    /// </summary>
    public partial class ViewPage : Page
    {
        Contact contact;
        public ViewPage(Contact contact)
        {
            InitializeComponent();
            this.contact = contact;
            FirstNameBox.Text = contact.fn;
            LastNameBox.Text = contact.ln;
            EmailBox.Text = contact.email;
            PhoneBox.Text = contact.phone;

        }

        
    }
}
