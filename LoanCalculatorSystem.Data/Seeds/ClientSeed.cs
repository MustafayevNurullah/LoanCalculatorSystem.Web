using LoanCalculatorSystem.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanCalculatorSystem.Data.Seeds
{
    class ClientSeed : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasData(new Client { CLientUniqueID = "1", Name = "Nurullah",Surname="Mustafayev",TelephoneNr="0559771567" },
               new Client { CLientUniqueID = "2", Name = "Tural", Surname = "Mustafayev", TelephoneNr = "0557778899" });
        }
    }
}
