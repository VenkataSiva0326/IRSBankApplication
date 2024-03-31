using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRSBankApplication.Application.Adminstrator.Response.Commands;
using IRSBankApplication.Application.Common.Errors;
using IRSBankApplication.Application.Common.Interfaces.Persistence;
using IRSBankApplication.Domain.Aggregates;
using MediatR;

namespace IRSBankApplication.Application.Adminstrator.Commands.AddAccountCredit
{
    public class AddAccountCreditCommandHandler : IRequestHandler<AddAccountCreditCommand, AddAccountCreditResult>
    {
        private readonly IAdminstratorRepository _adminstratorRepository;

        public AddAccountCreditCommandHandler(IAdminstratorRepository adminstratorRepository)
        {
            _adminstratorRepository = adminstratorRepository;
        }

        public async Task<AddAccountCreditResult> Handle(AddAccountCreditCommand request, CancellationToken cancellationToken)
        {
            var result = await _adminstratorRepository.AddAccountCredit(request.AccountId, request.Amount);
            if (result is not TransferAggregate transferDetails)
            {
                throw new InternalServerError();
            }
            return new AddAccountCreditResult(result);
        }
    }
}
