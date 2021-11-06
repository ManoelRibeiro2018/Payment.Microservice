using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreeela.Payments.API.Model
{
    public class PaymentInfoInputModel
    {
        public int IdProjeto { get; set; }
        public string CreditCardNumber { get; set; }
        public string Cvv { get; set; }
        public string ExpiresAT { get; set; }
        public string FullName { get; set; }
        public string Amount { get; set; }
    }
}
