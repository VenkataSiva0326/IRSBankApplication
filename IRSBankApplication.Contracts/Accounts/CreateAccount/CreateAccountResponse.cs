using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRSBankApplication.Contracts.Accounts.CreateAccount
{
    public record CreateAccountResponse(
        int AccountId,
        string Frequency,
        DateTime Created,
        decimal Balance,
        int AccountTypesId);
}
