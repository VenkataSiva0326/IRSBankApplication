using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRSBankApplication.Domain.Aggregates;

namespace IRSBankApplication.Application.Common.Interfaces.Persistence
{
    public interface ITransactionsRepository
    {
        Task<TransferAggregate> Transfer(Guid userId, int accountId, string operation, decimal amount, string account);
        Task<IEnumerable<AccountAggregate?>> GetTransactionsByAccId(Guid userId, int accountId);

    }
}
