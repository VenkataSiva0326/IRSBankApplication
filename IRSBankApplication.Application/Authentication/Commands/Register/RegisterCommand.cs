using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRSBankApplication.Application.Authentication.Common;
using MediatR;

namespace IRSBankApplication.Application.Authentication.Commands.Register
{
    public record RegisterCommand(
    string Email,
    string Password,
    string Role) : IRequest<AuthenticationResult>;
}
