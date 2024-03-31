using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRSBankApplication.Contracts.Accounts.CreateAccount
{
    public record CreateAccountRequestData(
    Guid UserId,
    string Frequency,
    int AccountTypesId);
}
