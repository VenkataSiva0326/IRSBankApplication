using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRSBankApplication.Application.Accounts.Response.Commands;
using MediatR;

namespace IRSBankApplication.Application.Accounts.Commands.CreateAccount
{
    public record CreateAccountCommand(
     Guid UserId,
     string Frequency,
     int AccountTypesId
     ) : IRequest<CreateAccountResult>;
}
