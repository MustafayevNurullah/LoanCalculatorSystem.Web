using AutoMapper;
using LoanCalculatorSystem.Core.Models;
using LoanCalculatorSystem.Web.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanCalculatorSystem.Web.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Client, ClientDto>();
            CreateMap<ClientDto, Client>();

        }
    }
}
