using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRSBankApplication.Domain.Aggregates;

namespace IRSBankApplication.Application.Accounts.Response.Commands
{
    public record TransferResult(TransferAggregate Transfer);

}
