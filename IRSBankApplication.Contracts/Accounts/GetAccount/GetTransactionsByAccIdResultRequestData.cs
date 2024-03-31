using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRSBankApplication.Contracts.Accounts.GetAccount
{
    public record GetTransactionsByAccIdResultRequestData(
    Guid UserId,
    int AccountId);
}
