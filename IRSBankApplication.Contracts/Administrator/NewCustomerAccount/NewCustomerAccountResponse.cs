using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRSBankApplication.Contracts.Administrator.NewCustomerAccount
{
    public record NewCustomerAccountResponse(
    int DispositionId,
    Customer Customer,
    Account Account,
    User User

    );

    public record Customer(
        string Gender,
        string Givenname,
        string Surname,
        string Streetaddress,
        string City,
        string Zipcode,
        string Country,
        string? Telephonenumber,
        string Emailaddress);

    public record Account(
        int AccountId,
        string? Frequency,
        decimal Balance,
        int AccountTypesId);

    public record User(
        Guid UserId,
        string Email,
        string Password,
        string Role);
}
