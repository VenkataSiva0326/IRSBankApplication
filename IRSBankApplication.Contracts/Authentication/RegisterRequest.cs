﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRSBankApplication.Contracts.Authentication
{
    public record RegisterRequest(
    [Required]
    string Email,
    [Required]
    string Password,
    [Required]
    string Role
);
}
