﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement.BL.Dto
{
    public class SignInDto
    {
        public string Email {  get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
