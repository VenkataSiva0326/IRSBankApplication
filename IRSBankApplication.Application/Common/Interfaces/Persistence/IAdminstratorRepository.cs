using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRSBankApplication.Domain.Aggregates;

namespace IRSBankApplication.Application.Common.Interfaces.Persistence
{
    public interface IAdminstratorRepository
    {
        Task<TransferAggregate> AddAccountCredit(int accountId, decimal amount);
    }
}
