using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRSBankApplication.Application.Authentication.Common;
using IRSBankApplication.Application.Common.Errors;
using IRSBankApplication.Application.Common.Interfaces.Authentication;
using IRSBankApplication.Application.Common.Interfaces.Persistence;
using IRSBankApplication.Domain.Entities;
using MediatR;

namespace IRSBankApplication.Application.Authentication.Commands.Register
{
    public class RegisterCommandHandler :
    IRequestHandler<RegisterCommand, AuthenticationResult>
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUserRepository _userRepository;

        public RegisterCommandHandler(IUserRepository userRepository, IJwtTokenGenerator jwtTokenGenerator)
        {
            _userRepository = userRepository;
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public async Task<AuthenticationResult> Handle(RegisterCommand command, CancellationToken cancellationToken)
        {
            //validate so that user doesn't exists
            if (await _userRepository.GetUserByEmail(command.Email) is not null)
            {
                throw new DuplicateEmailException();
            }

            var user = new User
            {
                Email = command.Email,
                Password = command.Password,
                Role = command.Role

            };

            _userRepository.Add(user);

            var token = _jwtTokenGenerator.GenerateToken(user);

            return new AuthenticationResult(
                user,
                token);
        }
    }
}
