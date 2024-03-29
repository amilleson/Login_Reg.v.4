using System;
using System.ComponentModel.DataAnnotations;

namespace login_register.Models
{
    public class LoginUser
    {
        [Required]
        public string Email {get; set;}

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}