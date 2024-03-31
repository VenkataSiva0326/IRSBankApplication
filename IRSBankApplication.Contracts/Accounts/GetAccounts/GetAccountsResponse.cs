using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRSBankApplication.Contracts.Accounts.GetAccounts
{
    public record GetAccountsResponse(
    List<AccountsListResponse> Accounts);

    public record AccountsListResponse(
        int AccountId,
        int AccountTypesId,
        DateTime Created,
        string Frequency,
        decimal Balance);

}
