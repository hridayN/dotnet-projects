using ExpenseManagerAPI.Database;
using ExpenseManagerAPI.Interface;
using ExpenseManagerAPI.Models;
using ExpenseManagerAPI.Settings;
using System.Data;
using System.Data.SqlClient;

namespace ExpenseManagerAPI.Services
{
    public class PaymentMethodManager : IPaymentMethod
    {
        private readonly IDBService _dbService;

        public PaymentMethodManager(IDBService dBService)
        {
            this._dbService = dBService;
        }
        SavePaymentMethodResponse IPaymentMethod.AddPaymentMethod(SavePaymentMethodRequest savePaymentMethodRequest)
        {
            List<IDbDataParameter> parameters = new List<IDbDataParameter>()
            {
                new SqlParameter() { ParameterName = "@Name", Value = savePaymentMethodRequest.PaymentMethod.Name },
                new SqlParameter() { ParameterName = "@BillingDate", Value = savePaymentMethodRequest.PaymentMethod.BillingDate },
                new SqlParameter() { ParameterName = "@GradePeriodDays", Value = savePaymentMethodRequest.PaymentMethod.GracePeriod }
            };
            this._dbService.ExecuteNonQueryStoredProcedure(DBProcedures.SP_AddPaymentMethod, parameters);
            SavePaymentMethodResponse savePaymentMethodResponse = new SavePaymentMethodResponse
            {
                StatusMessage = "Payment method added"
            };
            return savePaymentMethodResponse;
        }
    }
}
