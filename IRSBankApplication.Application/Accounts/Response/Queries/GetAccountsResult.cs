using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRSBankApplication.Domain.Entities;

namespace IRSBankApplication.Application.Accounts.Response.Queries
{
    public record GetAccountsResult(IEnumerable<Account> account);
}
