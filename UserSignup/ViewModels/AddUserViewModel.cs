using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using UserSignup.Models;

namespace UserSignup.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Need a user name.")]
        [StringLength(20, MinimumLength = 4)]
        public string Username { get; set; }


        [Required(ErrorMessage = "Need a valid password.")]
        [StringLength(25, MinimumLength = 6)]
        public string Password { get; set; }

        [Required(ErrorMessage ="Need a valid password.")]
        [Display(Name ="Verify Password")]
        [Compare("Password", ErrorMessage ="Passwords do not match.")]
        public string Verify { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        private DateTime CreateDate { get; set; }


    }
}
