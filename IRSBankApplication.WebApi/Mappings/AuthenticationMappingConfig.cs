using IRSBankApplication.Application.Authentication.Common;
using IRSBankApplication.Contracts.Authentication;
using Mapster;

namespace IRSBankApplication.WebApi.Mappings
{
    public class AuthenticationMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<AuthenticationResult, AuthenticationResponse>()
                .Map(dest => dest.Token, src => src.Token)
                .Map(dest => dest, src => src.user)
                .Map(dest => dest.userId, src => src.user.UserId);

        }
    }
}
