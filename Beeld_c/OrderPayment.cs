namespace BeeldC
{
    public class OrderPayment
    {
        public float Amount { get; set; }
        public string TransferType { get; set; }

        public OrderPayment(float amount, string transferType)
        {
            this.Amount = amount;
            this.TransferType = transferType;
        }

        public OrderPayment()
        {
        }
    }
}