namespace ExpenseManagerAPI.Models
{
    public class Expense
    {
        public string Name { get; set; }
        public int PaymentMethodId { get; set; }
        public int ExpenseCategoryId { get; set; }
        public DateOnly ExpenseDate { get; set; }
    }
}
