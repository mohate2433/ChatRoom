﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.New.ViewModels.Auth
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="این نام کاربری خود را وارد نمایید")]
        public string? UserName { get; set; }
        [Required(ErrorMessage ="این کلمه عبور خود را وارد نمایید")]
        public string? Password { get; set; }
        [Compare("Password",ErrorMessage ="کلمه عبور وارد شده با کلمه عبور بالا یکسان نیست")]
        public string? RePassword { get; set; }
    }
}
