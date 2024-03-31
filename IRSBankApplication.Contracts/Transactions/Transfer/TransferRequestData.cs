using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRSBankApplication.Contracts.Transactions.Transfer
{
    public record TransferRequestData(
    Guid UserId,
    int AccountId,
    int Operation,
    decimal Amount,
    string Account);

}
