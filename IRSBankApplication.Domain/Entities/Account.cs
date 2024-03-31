using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace IRSBankApplication.Domain.Entities
{
    public partial class Account
    {

        public int AccountId { get; set; }

        public string Frequency { get; set; } = null!;

        public DateTime Created { get; set; }

        public decimal Balance { get; set; }

        public int? AccountTypesId { get; set; }

        public virtual AccountType? AccountTypes { get; set; }

        public virtual ICollection<Disposition> Dispositions { get; } = new List<Disposition>();

        public virtual ICollection<Loan> Loans { get; } = new List<Loan>();

        public virtual ICollection<Transaction> Transactions { get; } = new List<Transaction>();
        public User User { get; set; }
    }
}
