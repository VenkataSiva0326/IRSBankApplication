using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRSBankApplication.Contracts.Administrator.AddAccountCredit
{
    public record AddAccountCreditRequest(
     [Required]
    int AccountId,
     decimal Amount);
}
