using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRSBankApplication.Domain.Aggregates;

namespace IRSBankApplication.Application.Adminstrator.Response.Commands
{
    public record AddAccountCreditResult(TransferAggregate Transfer);
}
