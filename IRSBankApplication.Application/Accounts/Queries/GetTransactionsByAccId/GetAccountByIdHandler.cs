using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRSBankApplication.Application.Accounts.Response.Queries;
using IRSBankApplication.Application.Common.Errors;
using IRSBankApplication.Application.Common.Interfaces.Persistence;
using MediatR;

namespace IRSBankApplication.Application.Accounts.Queries.GetTransactionsByAccId
{
    public class GetAccountByIdHandler : IRequestHandler<GetTransactionsByAccIdQuery, GetTransactionsByAccIdResult>
    {
        private readonly ITransactionsRepository _TransactionsRepository;

        public GetAccountByIdHandler(ITransactionsRepository transactionsRepository)
        {
            _TransactionsRepository = transactionsRepository;
        }

        public async Task<GetTransactionsByAccIdResult> Handle(GetTransactionsByAccIdQuery query, CancellationToken cancellationToken)
        {
            if (query.AccountId == 0)
            {
                // return notfound
                throw new InvalidAccount();
            }
            var result = await _TransactionsRepository.GetTransactionsByAccId(query.UserId, query.AccountId);
            if (result is null)
            {
                throw new InvalidAccount();
            }
            return new GetTransactionsByAccIdResult(result);

        }

    }
}
