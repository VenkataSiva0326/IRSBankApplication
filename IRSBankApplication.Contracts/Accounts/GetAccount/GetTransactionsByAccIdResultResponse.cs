using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRSBankApplication.Contracts.Accounts.GetAccount
{
    public record GetTransactionsByAccIdResultResponse(
    // int AccountId,
    //int AccountTypesId,
    //DateTime Created,
    //string Frequency,
    //decimal Balance,
    List<AccountTransactionsResponse> Transactions);

    public record AccountTransactionsResponse(
        int TransactionId,
        string AccountId,
        DateTime Date,
        string Type,
        string Operation,
        decimal Amount,
        decimal Balance,
        string Account
        );
}
