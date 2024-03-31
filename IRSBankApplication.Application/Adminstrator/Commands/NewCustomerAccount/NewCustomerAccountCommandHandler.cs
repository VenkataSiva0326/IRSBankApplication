using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRSBankApplication.Application.Adminstrator.Response.Commands;
using IRSBankApplication.Application.Common.Errors;
using IRSBankApplication.Application.Common.Interfaces.Persistence;
using IRSBankApplication.Application.Common.Services;
using IRSBankApplication.Domain.Aggregates;
using IRSBankApplication.Domain.Entities;
using MediatR;

namespace IRSBankApplication.Application.Adminstrator.Commands.NewCustomerAccount
{
    public class NewCustomerAccountCommandHandler : IRequestHandler<NewCustomerAccountCommand, NewCustomerAccountResult>
    {
        private readonly ICustomerRepository _customerRepository;

        public NewCustomerAccountCommandHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<NewCustomerAccountResult> Handle(NewCustomerAccountCommand request, CancellationToken cancellationToken)
        {
            var user = new User
            {
                Email = request.Emailaddress.ToLower(),
                Password = PasswordGenerator.RandomPassword(),
                Role = "customer",

            };
            var result = await _customerRepository.NewCustomerAccount(user, request);
            if (result is not NewCustomerAccountAggregate transferDetails)
            {
                throw new InternalServerError();
            }
            return new NewCustomerAccountResult(result);

        }
    }
}
