﻿using System;
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

namespace DotNetFinalProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //MessageBoxResult result = MessageBox.Show("Would you like to greet the world with a \"Hello, world\"?", "My App", MessageBoxButton.YesNoCancel);
            //switch (result)
            //{
            //    case MessageBoxResult.Yes:
            //        MessageBox.Show("Hello to you too!", "My App");
            //        break;
            //    case MessageBoxResult.No:
            //        MessageBox.Show("Oh well, too bad!", "My App");
            //        break;
            //    case MessageBoxResult.Cancel:
            //        MessageBox.Show("Nevermind then...", "My App");
            //        break;
            //}
            //MessageBox.Show("Hello!", "First MessageBox", MessageBoxButton.YesNoCancel, MessageBoxImage.Question, MessageBoxResult.Cancel);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            deleteContact objDeleteContactWindow = new deleteContact();
            this.Visibility = Visibility.Hidden; //hidding the current window
            objDeleteContactWindow.Show();

        }

    }
}
