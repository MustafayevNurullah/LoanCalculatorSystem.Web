using AutoMapper;
using LoanCalculatorSystem.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LoanCalculatorSystem.Web.Controllers
{
    public class LoanController:Controller
    {

       
        private readonly IClientService _clientService;

        private readonly ILoanService _loanService;
        private readonly IMapper _mapper;

        public LoanController(IClientService clietnService, IMapper mapper,ILoanService loanService)
        {
            _loanService = loanService;
            _clientService = clietnService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Calculator()
        {
            var clients = _clientService.GetClientsAsync();

            Thread.Sleep(5000);


            return View(clients.Result);
            
        }

        [HttpPost]
        public IActionResult Calculator(int amount,int month,int rate,DateTime date)
        {


            _loanService.CalculatedLoanAsync(amount, month, rate, date);
            return View(Ok());

        }
    }
}
