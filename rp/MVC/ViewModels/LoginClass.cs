using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.ViewModels
{
    public class LoginClass
    {
        [Required(ErrorMessage ="Please enter your username!")]
        [Display(Name ="Enter username: ")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please enter your password!")]
        [Display(Name = "Enter password: ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}