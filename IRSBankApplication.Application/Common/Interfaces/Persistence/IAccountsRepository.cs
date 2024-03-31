using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRSBankApplication.Domain.Entities;

namespace IRSBankApplication.Application.Common.Interfaces.Persistence
{
    public interface IAccountsRepository
    {
        Task<Account?> CreateAccount(Guid userId, string frequency, int AccountTypesId, int? CustomerId);
        Task<IEnumerable<Account>> GetAccounts(Guid userId);
    }
}
