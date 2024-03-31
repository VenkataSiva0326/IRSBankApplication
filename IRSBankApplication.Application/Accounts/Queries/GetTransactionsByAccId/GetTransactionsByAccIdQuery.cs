using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRSBankApplication.Application.Accounts.Response.Queries;
using MediatR;

namespace IRSBankApplication.Application.Accounts.Queries.GetTransactionsByAccId
{
    public record GetTransactionsByAccIdQuery(Guid UserId, int AccountId) : IRequest<GetTransactionsByAccIdResult>;

}
