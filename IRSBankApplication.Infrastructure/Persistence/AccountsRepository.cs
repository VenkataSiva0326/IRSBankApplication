using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using IRSBankApplication.Application.Common.Interfaces.Persistence;
using IRSBankApplication.Domain.Entities;
using IRSBankApplication.Infrastructure.DbContext;

namespace IRSBankApplication.Infrastructure.Persistence
{
    public class AccountsRepository : IAccountsRepository
    {
        private readonly DapperContext _context;

        public AccountsRepository(DapperContext context)
        {
            _context = context;
        }


        public async Task<Account?> CreateAccount(Guid userId, string frequency, int AccountTypesId, int? CustomerId)
        {
            using (var db = _context.CreateConnection())
            {
                try
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@customerId", CustomerId);
                    parameters.Add("@userId", userId);
                    parameters.Add("@frequency", frequency);
                    parameters.Add("@accountTypesId", AccountTypesId);
                    var result = await db.QuerySingleAsync<Account>("CreateAccount", parameters, commandType: CommandType.StoredProcedure);
                    return result;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public async Task<IEnumerable<Account>> GetAccounts(Guid userId)
        {
            using (var db = _context.CreateConnection())
            {
                return await db.QueryAsync<Account>("GetAccounts", new { userId }, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
