using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRSBankApplication.Contracts.Transactions.Transfer
{
    public record TransferRequest(
    [Required]
    int AccountId,
    [Range(1,2)]
    int Operation,
    [Required]
    decimal Amount,
    [Required]
    string Account);
}
