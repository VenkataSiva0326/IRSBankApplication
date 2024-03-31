using IRSBankApplication.Application.Accounts.Response.Queries;
using IRSBankApplication.Contracts.Accounts.GetAccounts;
using Mapster;

namespace IRSBankApplication.WebApi.Mappings
{
    public class GetAccountsMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<GetAccountsResult, GetAccountsResponse>()
                .Map(dest => dest.Accounts, src => src.account);
        }
    }
}
