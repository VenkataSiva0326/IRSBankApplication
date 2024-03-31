using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using IRSBankApplication.Application.Common.Errors;
using IRSBankApplication.Application.Common.Interfaces.Persistence;
using IRSBankApplication.Domain.Aggregates;
using IRSBankApplication.Infrastructure.DbContext;

namespace IRSBankApplication.Infrastructure.Persistence
{
    public class AdminstratorRepository : IAdminstratorRepository
    {
        private readonly DapperContext _context;

        public AdminstratorRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<TransferAggregate> AddAccountCredit(int accountId, decimal amount)
        {
            using (var db = _context.CreateConnection())
            {
                try
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@accountId", accountId);
                    parameters.Add("@creditDeposit", amount);

                    var result = await db.QueryFirstOrDefaultAsync<TransferAggregate>("AddAccountCredit", parameters, commandType: CommandType.StoredProcedure);

                    if (result is null)
                    {
                        throw new InvalidAccount();
                    }
                    return result;
                }
                catch (Exception)
                {
                    throw new InternalServerError();
                }
                throw new InternalServerError();
            }
        }
    }
}
