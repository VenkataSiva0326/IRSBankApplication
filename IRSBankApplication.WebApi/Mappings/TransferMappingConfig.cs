using IRSBankApplication.Application.Accounts.Response.Commands;
using IRSBankApplication.Contracts.Transactions.Transfer;
using Mapster;

namespace IRSBankApplication.WebApi.Mappings
{
    public class TransferMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<TransferResult, TransferResponse>()
                .Map(dest => dest.TransactionId, src => src.Transfer.TransactionId)
                .Map(dest => dest.RetrieverAccount, src => src.Transfer.AccountId)
                .Map(dest => dest.Date, src => src.Transfer.Date)
                .Map(dest => dest.Operation, src => src.Transfer.Operation)
                .Map(dest => dest.Amount, src => src.Transfer.Amount)
                .Map(dest => dest.Balance, src => src.Transfer.Balance)
                .Map(dest => dest.SenderAccount, src => src.Transfer.Account);
        }
    }
}
