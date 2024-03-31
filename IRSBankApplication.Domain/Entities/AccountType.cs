using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRSBankApplication.Domain.Entities
{
    public partial class AccountType
    {
        public int AccountTypeId { get; set; }

        public string TypeName { get; set; } = null!;

        public string? Description { get; set; }

        public virtual ICollection<Account> Accounts { get; } = new List<Account>();
    }
}
