using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace WpfWebService
{
    public partial class MainWindow : Window
    {
        private CreateRequest request = new CreateRequest();
        private string connectionStr = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;

        public MainWindow()
        {
            request.Execute();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var query = "SELECT TrackingNumber FROM TrackingNumbers";
            var table = new DataTable();    

            using (var connection = new SqlConnection(connectionStr))
            {
                using (var dataAdapter = new SqlDataAdapter(query, connectionStr))
                {
                    using (var command = new SqlCommand(query, connection))
                    {
                        dataAdapter.Fill(table);
                        TrackingDataGridView.DataContext = table;
                    }
                }
            }
        }
    }
}