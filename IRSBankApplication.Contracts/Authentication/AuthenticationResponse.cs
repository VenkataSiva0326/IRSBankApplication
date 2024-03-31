using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRSBankApplication.Contracts.Authentication
{
    public record AuthenticationResponse(
        Guid userId,
        string Email,
        string Role,
        string Token);
}
