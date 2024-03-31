using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRSBankApplication.Application.Accounts.Response.Commands;
using MediatR;

namespace IRSBankApplication.Application.Transactions.Commands.Transfer
{
    public record TransferCommand(
     Guid UserId,
     int AccountId,
     int Operation,
     decimal Amount,
     string Account) : IRequest<TransferResult>;
}
