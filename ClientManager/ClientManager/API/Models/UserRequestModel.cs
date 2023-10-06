﻿using API.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class UserRequestModel : BaseRequestModel
    {
        public UserRequestModel() : base()
        {
        }

        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Nome { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Role { get; set; }
    }
}
