﻿using Online_Shop___BackEnd.Models;
using System.ComponentModel.DataAnnotations;

namespace Online_Shop___BackEnd.ViewModels
{
    public class AccountVM
    {
        public Login_Register Login_Registers { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
