using IRSBankApplication.Application.Accounts.Response.Commands;
using IRSBankApplication.Contracts.Accounts.CreateAccount;
using Mapster;

namespace IRSBankApplication.WebApi.Mappings
{
    public class CreateAccountMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<CreateAccountResult, CreateAccountResponse>()
                .Map(dest => dest.AccountId, src => src.Account.AccountId)
                .Map(dest => dest.Frequency, src => src.Account.Frequency)
                .Map(dest => dest.Created, src => src.Account.Created)
                .Map(dest => dest.Balance, src => src.Account.Balance)
                .Map(dest => dest.AccountTypesId, src => src.Account.AccountTypesId);
        }
    }
}
