using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRSBankApplication.Contracts.Administrator.NewCustomerAccount
{
    public record NewCustomerAccountRequest(
     [Required]
    string Gender,
     [Required]
    string Givenname,
     [Required]
    string Surname,
     [Required]
    string Streetaddress,
     [Required]
    string City,
     [Required]
    string Zipcode,
     [Required]
    string Country,
     [Required]
    string CountryCode,
     DateTime? Birthday,
     string? Telephonecountrycode,
     string? Telephonenumber,
     [Required]
    string Emailaddress,
     CustomerAccount CustomerAccount
     );

    public record CustomerAccount(
        [Required]
    int AccountTypesId,
        string? Frequency);
}
