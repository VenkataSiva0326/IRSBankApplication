using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRSBankApplication.Application.Adminstrator.Response.Commands;
using MediatR;

namespace IRSBankApplication.Application.Adminstrator.Commands.NewCustomerAccount
{
    public record NewCustomerAccountCommand(
    string Gender,
    string Givenname,
    string Surname,
    string Streetaddress,
    string City,
    string Zipcode,
    string Country,
    string CountryCode,
    DateTime? Birthday,
    string? Telephonecountrycode,
    string? Telephonenumber,
    string Emailaddress,
    CustomerAccount CustomerAccount

    ) : IRequest<NewCustomerAccountResult>;

    public record CustomerAccount(
        [Required]
    int AccountTypesId,
        string? Frequency);
}
