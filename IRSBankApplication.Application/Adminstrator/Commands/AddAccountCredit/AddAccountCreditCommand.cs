using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRSBankApplication.Application.Adminstrator.Response.Commands;
using MediatR;

namespace IRSBankApplication.Application.Adminstrator.Commands.AddAccountCredit
{
    public record AddAccountCreditCommand(
    Guid UserId,
    int AccountId,
    int Operation,
    decimal Amount,
    string Account
    ) : IRequest<AddAccountCreditResult>;
}
