using ExpenseManagerAPI.Interface;
using ExpenseManagerAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseManagerAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PaymentMethodController : ControllerBase
    {
        private readonly IPaymentMethod _paymentMethod;
        public PaymentMethodController(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        [Route("AddPaymentMethod")]
        [HttpPost]
        public SavePaymentMethodResponse SavePaymentMethod(SavePaymentMethodRequest savePaymentMethodRequest)
        {
            return _paymentMethod.AddPaymentMethod(savePaymentMethodRequest);
        }

    }
}
