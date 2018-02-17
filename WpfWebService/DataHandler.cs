using System.Configuration;
using System.Data.SqlClient;

namespace WpfWebService
{
    class DataHandler
    {

        private string connectionStr = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;

        public void LoadData(string trackingNumbers)
        {

            using (var connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                //do things with data here
            }
        }
    }
}