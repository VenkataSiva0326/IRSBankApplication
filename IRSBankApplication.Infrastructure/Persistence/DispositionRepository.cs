using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using IRSBankApplication.Application.Common.Interfaces.Persistence;
using IRSBankApplication.Infrastructure.DbContext;

namespace IRSBankApplication.Infrastructure.Persistence
{
    public class DispositionRepository : IDispositionRepository
    {
        private readonly DapperContext _context;

        public DispositionRepository(DapperContext context)
        {
            _context = context;
        }


        public async Task<int?> GetCustomerIdFromDisposition(Guid userId)
        {
            using (var db = _context.CreateConnection())
            {
                try
                {
                    var customerId = await db.QuerySingleAsync<int>("GetCustomerIdDispostion", new { userId }, commandType: CommandType.StoredProcedure);
                    return customerId;

                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
    }
}
