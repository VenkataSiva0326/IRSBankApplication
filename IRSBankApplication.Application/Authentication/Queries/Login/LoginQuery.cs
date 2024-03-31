using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRSBankApplication.Application.Authentication.Common;
using MediatR;

namespace IRSBankApplication.Application.Authentication.Queries.Login
{
    public record LoginQuery(
    string Email,
    string Password) : IRequest<AuthenticationResult>;
}
