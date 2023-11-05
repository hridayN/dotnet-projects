using ExpenseManagerAPI.Interface;
using ExpenseManagerAPI.Models;

namespace ExpenseManagerAPI.Services
{
    public class PaymentMethodManager : IPaymentMethod
    {
        SavePaymentMethodResponse IPaymentMethod.AddPaymentMethod(SavePaymentMethodRequest savePaymentMethodRequest)
        {
            SavePaymentMethodResponse savePaymentMethodResponse = new SavePaymentMethodResponse
            {
                StatusMessage = "Payment method added"
            };
            return savePaymentMethodResponse;
        }
    }
}
