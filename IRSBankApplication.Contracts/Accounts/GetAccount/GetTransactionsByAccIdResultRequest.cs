using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRSBankApplication.Contracts.Accounts.GetAccount
{
    public record GetTransactionsByAccIdResultRequest([Required] int AccountId);
}
