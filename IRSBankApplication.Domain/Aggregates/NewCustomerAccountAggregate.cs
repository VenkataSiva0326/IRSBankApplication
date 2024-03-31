using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using IRSBankApplication.Domain.Entities;

namespace IRSBankApplication.Domain.Aggregates
{
    public class NewCustomerAccountAggregate
    {
        public int DispositionId { get; set; }

        public int CustomerId { get; set; }

        public int AccountId { get; set; }

        public Guid UserId { get; set; }

        public virtual Account Account { get; set; } = null!;

        public virtual Customer Customer { get; set; } = null!;

        public virtual User? User { get; set; } = null!;
    }
}
