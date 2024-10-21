using System;

namespace BeeldC
{
    public class Order
    {
        private string description { get; set; }
        private string status { get; set; }

        public Order(String description, String status)
        {
            this.description = description;
            this.status = status;
        }
    }
}