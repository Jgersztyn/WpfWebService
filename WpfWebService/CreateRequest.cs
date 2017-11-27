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
            DateTime startTime;
            DateTime endTime;

            using (GetOrders.orders_internalSoapClient proxy = new GetOrders.orders_internalSoapClient())
            {
            }
        }
    }
}