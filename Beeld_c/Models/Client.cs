using System.Collections.Generic;

namespace BeeldC
{
    public class Client
    {
        private List<Order> orders { get; set; }


        public Client()
        {
        }

        public Client(List<Order> orders)
        {
            this.orders = orders;
        }

        public void SearchByCategory(string orderId)
        {
        }

        public void OrderService()
        {
            
        }

    }
}