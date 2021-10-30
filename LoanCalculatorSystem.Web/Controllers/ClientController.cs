using AutoMapper;
using LoanCalculatorSystem.Core.Models;
using LoanCalculatorSystem.Core.Services;
using LoanCalculatorSystem.Web.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LoanCalculatorSystem.Web.Controllers
{
    public class ClientController: Controller
    {
        private readonly IClientService _clientService;
        private readonly IMapper _mapper;

        public ClientController(IClientService clientService, IMapper mapper)
        {
            _clientService = clientService;
            _mapper = mapper;
        }

        public  IActionResult Clients()
        {
            var clients =  _clientService.GetClientsAsync();

            Thread.Sleep(5000);

            return View(clients.Result);
        }
    }
}
