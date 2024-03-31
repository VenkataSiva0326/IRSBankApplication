using IRSBankApplication.Application.Accounts.Response.Queries;
using IRSBankApplication.Contracts.Accounts.GetAccount;
using Mapster;

namespace IRSBankApplication.WebApi.Mappings
{
    public class GetAccountByIdMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<GetTransactionsByAccIdResult, GetTransactionsByAccIdResultResponse>()
                .Map(dest => dest.Transactions, src => src.Account);

        }
    }
}
