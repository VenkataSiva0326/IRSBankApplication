using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRSBankApplication.Contracts.Accounts.CreateAccount
{
    public record CreateAccountRequest(
    int AccountTypesId,
    string Frequency);
}
