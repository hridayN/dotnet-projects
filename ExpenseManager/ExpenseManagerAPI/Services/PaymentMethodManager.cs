using ExpenseManagerAPI.Interface;
using ExpenseManagerAPI.Models;
using ExpenseManagerAPI.Settings;
using System.Data.SqlClient;

namespace ExpenseManagerAPI.Services
{
    public class PaymentMethodManager : IPaymentMethod
    {
        private DBConfigurations _dbConfigurations;

        public PaymentMethodManager(DBConfigurations dBConfigurations)
        {
            this._dbConfigurations = dBConfigurations;
        }
        SavePaymentMethodResponse IPaymentMethod.AddPaymentMethod(SavePaymentMethodRequest savePaymentMethodRequest)
        {
            SqlConnection sqlConnection = this._dbConfigurations.GetSqlConnection();
            sqlConnection.Open();

            sqlConnection.Close();

            SavePaymentMethodResponse savePaymentMethodResponse = new SavePaymentMethodResponse
            {
                StatusMessage = "Payment method added"
            };
            return savePaymentMethodResponse;
        }
    }
}
