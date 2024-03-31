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
    public class UserRepository : IUserRepository
    {
        private readonly DapperContext _context;

        public UserRepository(DapperContext context)
        {
            _context = context;
        }

        public void Add(User user)
        {
            using (var db = _context.CreateConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@UserId", user.UserId);
                parameters.Add("@Email", user.Email);
                parameters.Add("@Password", user.Password);
                parameters.Add("@Role", user.Role);
                db.ExecuteScalar("AddUser", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<User?> GetUserByEmail(string email)
        {
            using (var db = _context.CreateConnection())
            {
                try
                {
                    return await db.QuerySingleAsync<User>("GetUserByEmail", new { email }, commandType: CommandType.StoredProcedure);
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
    }
}
