using System;

namespace WpfWebService
{
    class CreateRequest
    {
        private string trackingNumbers;
        private DataHandler handler;

        public CreateRequest()
        {
            trackingNumbers = "";
            handler = new DataHandler();
        }

        public void Execute()
        {
            DateTime startTime = new DateTime(2013, 8, 30);
            DateTime endTime = new DateTime(2017, 5, 20);

            using (GetOrders.orders_internalSoapClient proxy = new GetOrders.orders_internalSoapClient())
            {
                proxy.GetOrdersByStatus("29475d4e-34d8-4883-b6f0-f6836ddd60b4", 2, startTime, endTime);
            }

            handler.LoadData(trackingNumbers);
        }
    }
}