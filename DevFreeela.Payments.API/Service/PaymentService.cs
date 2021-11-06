using DevFreeela.Payments.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreeela.Payments.API.Service
{
    public class PaymentService : IPaymentService
    {
        public Task<bool> Process(PaymentInfoInputModel paymentInfoInput)
        {
            return Task.FromResult(true);
        }
    }
}
