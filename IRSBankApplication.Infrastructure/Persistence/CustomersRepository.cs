﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using IRSBankApplication.Application.Adminstrator.Commands.NewCustomerAccount;
using IRSBankApplication.Application.Common.Errors;
using IRSBankApplication.Application.Common.Interfaces.Persistence;
using IRSBankApplication.Domain.Aggregates;
using IRSBankApplication.Domain.Entities;
using IRSBankApplication.Infrastructure.DbContext;

namespace IRSBankApplication.Infrastructure.Persistence
{
    public class CustomersRepository : ICustomerRepository
    {
        private readonly DapperContext _context;

        public CustomersRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<NewCustomerAccountAggregate> NewCustomerAccount(User user, NewCustomerAccountCommand command)
        {
            using (var db = _context.CreateConnection())
            {
                DynamicParameters dynamic = new DynamicParameters();
                dynamic.Add("@email", command.Emailaddress);
                var userExist = await db.QuerySingleOrDefaultAsync<User>("GetUserByEmail", dynamic, commandType: CommandType.StoredProcedure);
                if (userExist != null)
                {
                    throw new DuplicateEmailException();
                }
                try
                {

                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@Gender", command.Gender);
                    parameters.Add("@Givenname", command.Givenname);
                    parameters.Add("@Surname", command.Surname);
                    parameters.Add("@Streetaddress", command.Streetaddress);
                    parameters.Add("@City", command.City);
                    parameters.Add("@Zipcode", command.Zipcode);
                    parameters.Add("@Country", command.Country);
                    parameters.Add("@CountryCode", command.CountryCode);
                    parameters.Add("@Birthday", command.Birthday);
                    parameters.Add("@Telephonecountrycode", command.Telephonecountrycode);
                    parameters.Add("@Telephonenumber", command.Telephonenumber);
                    parameters.Add("@Emailaddress", command.Emailaddress);
                    var customer = await db.QuerySingleAsync<Customer>("CreateCustomer", parameters, commandType: CommandType.StoredProcedure);


                    DynamicParameters parameters2 = new DynamicParameters();
                    parameters2.Add("@UserId", user.UserId);
                    parameters2.Add("@Email", command.Emailaddress);
                    parameters2.Add("@Password", user.Password);
                    parameters2.Add("@Role", user.Role);
                    db.ExecuteScalar("AddUser", parameters2, commandType: CommandType.StoredProcedure);


                    //Insert to account & Disposition customerID
                    DynamicParameters para = new DynamicParameters();
                    para.Add("@customerId", customer.CustomerId);
                    para.Add("@userId", user.UserId);
                    para.Add("@frequency", command.CustomerAccount.Frequency);
                    para.Add("@accountTypesId", command.CustomerAccount.AccountTypesId);

                    var ListNewCustomer = await db.QueryAsync<NewCustomerAccountAggregate, Account, Customer, User, NewCustomerAccountAggregate>("CreateAccountReturnDisposition", (aggregate, account, customer, user) =>
                    {
                        aggregate.Account = account;
                        aggregate.Customer = customer;
                        aggregate.User = user;
                        return aggregate;
                    }, para, commandType: CommandType.StoredProcedure, splitOn: "AccountId, CustomerId, UserId");

                    var result = ListNewCustomer.First();
                    return result;

                }
                catch (Exception)
                {
                    throw new InternalServerError();
                }
            }
        }
    }
}
