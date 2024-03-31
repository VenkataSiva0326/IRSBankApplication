using IRSBankApplication.Application.Adminstrator.Response.Commands;
using IRSBankApplication.Contracts.Administrator.NewCustomerAccount;
using Mapster;

namespace IRSBankApplication.WebApi.Mappings
{
    public class NewCustomerAccountMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<NewCustomerAccountResult, NewCustomerAccountResponse>()
                .Map(dest => dest.DispositionId, src => src.DispositionCustomerAccount.DispositionId)
                .Map(dest => dest.Customer, src => src.DispositionCustomerAccount.Customer)
                .Map(dest => dest.Account, src => src.DispositionCustomerAccount.Account)
                .Map(dest => dest.User, src => src.DispositionCustomerAccount.User);
        }
    }
}
