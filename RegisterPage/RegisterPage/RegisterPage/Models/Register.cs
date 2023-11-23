using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RegisterPage.Models
{
    public class Register
    {
        public string Firstname { get; set; }   
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string confirmPassword { get; set; }
        public bool ShowSubscribe { get; set; }
    }
}