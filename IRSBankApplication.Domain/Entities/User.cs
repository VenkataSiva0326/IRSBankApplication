using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRSBankApplication.Domain.Entities
{
    public class User
    {
        public Guid UserId { get; set; } = Guid.NewGuid();

        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string Role { get; set; } = null!;


        public List<Account> Accounts = new List<Account>();
    }
}
