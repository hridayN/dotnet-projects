namespace ExpenseManagerAPI.Models
{
    public class PaymentMethod
    {
        public string Name { get; set; }
        public DateOnly BillingDate { get; set; }
        public int GracePeriod { get; set; }
    }
}
