using DevFreeela.Payments.API.Model;
using DevFreeela.Payments.API.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreeela.Payments.API.Controllers
{
    [Route("api/Payments")]
    public class PaymentController : Controller
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PaymentInfoInputModel paymentInfoInput)
        {
            var result = await _paymentService.Process(paymentInfoInput);
            if (!result)
            {
                return BadRequest();
            }

            return Ok(result);
        }
    }
}
