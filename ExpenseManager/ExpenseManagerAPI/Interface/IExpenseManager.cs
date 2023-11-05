using ExpenseManagerAPI.Models;

namespace ExpenseManagerAPI.Interface
{
    public interface IExpenseManager
    {
        SaveExpenseResponse AddExpense(SaveExpenseRequest saveExpenseRequest);

        GetExpenseResponse GetExpenses(GetExpenseRequest getExpenseRequest);
    }
}
