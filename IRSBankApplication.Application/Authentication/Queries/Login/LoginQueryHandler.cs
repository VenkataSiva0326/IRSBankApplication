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

namespace IRSBankApplication.Application.Authentication.Queries.Login
{
    public class LoginQueryHandler :
    IRequestHandler<LoginQuery, AuthenticationResult>
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUserRepository _userRepository;

        public LoginQueryHandler(IUserRepository userRepository, IJwtTokenGenerator jwtTokenGenerator)
        {
            _userRepository = userRepository;
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public async Task<AuthenticationResult> Handle(LoginQuery query, CancellationToken cancellationToken)
        {
            if (await _userRepository.GetUserByEmail(query.Email) is not User user)
            {
                throw new InvalidUser();
            }


            if (user.Password != query.Password)
            {
                throw new InvalidPassword();
            }

            var token = _jwtTokenGenerator.GenerateToken(user);

            return new AuthenticationResult(
                user,
                token);
        }
    }
}
