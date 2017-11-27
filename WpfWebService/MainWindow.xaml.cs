using System;
using System.Configuration;
using System.Windows;

namespace WpfWebService
{
    public partial class MainWindow : Window
    {
        private CreateRequest request = new CreateRequest();
        private string connection = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Display the results using this action
        }
    }
}