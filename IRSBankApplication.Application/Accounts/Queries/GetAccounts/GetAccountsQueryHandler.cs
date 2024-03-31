using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRSBankApplication.Application.Accounts.Response.Queries;
using IRSBankApplication.Application.Common.Errors;
using IRSBankApplication.Application.Common.Interfaces.Persistence;
using MediatR;

namespace IRSBankApplication.Application.Accounts.Queries.GetAccounts
{
    public class GetAccountsQueryHandler : IRequestHandler<GetAccountsQuery, GetAccountsResult>
    {
        private readonly IAccountsRepository _AccountsRepository;

        public GetAccountsQueryHandler(IAccountsRepository accountsRepository)
        {
            _AccountsRepository = accountsRepository;
        }

        public async Task<GetAccountsResult> Handle(GetAccountsQuery query, CancellationToken cancellationToken)
        {
            if (query.UserId == Guid.Empty)
            {
                throw new InvalidUser();
            }
            var result = await _AccountsRepository.GetAccounts(query.UserId);

            return new GetAccountsResult(result);

        }

    }
}
