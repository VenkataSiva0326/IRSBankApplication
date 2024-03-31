using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRSBankApplication.Application.Adminstrator.Commands.NewCustomerAccount;
using IRSBankApplication.Domain.Aggregates;
using IRSBankApplication.Domain.Entities;

namespace IRSBankApplication.Application.Common.Interfaces.Persistence
{
    public interface ICustomerRepository
    {
        Task<NewCustomerAccountAggregate> NewCustomerAccount(User user, NewCustomerAccountCommand command);
    }
}
