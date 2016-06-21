using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace WebSiteProjectA.Models
{
    public class UsersContext : DbContext
    {
        public UsersContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
    }

    [Table("UserProfile")]
    public class UserProfile
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Email address")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Please type a valid email address")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please type a valid email address")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "First name")]
        [StringLength(150, ErrorMessage = "Sorry your first name is too long to fit in the user list")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last name")]
        [StringLength(150, ErrorMessage = "Sorry your last name is too long to fit in the user list")]
        public string LastName { get; set; }


        [Display(Name = "Middle name")]
        [StringLength(150, ErrorMessage = "Sorry your middle name is too long to fit in the user list")]
        public string MiddleName { get; set; }

        [Required]
        [Display(Name = "Phone number")]
        [DisplayFormat(DataFormatString = "{0:# ###.###.####}")]
        [StringLength(20, ErrorMessage = "Sorry your middle name is too long to fit in the user list")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Please type a valid phone number")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date, ErrorMessage = "Please enter a valid Date.")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }
    }

    public class RegisterExternalLoginModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        public string ExternalLoginData { get; set; }
    }

    public class LocalPasswordModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[$@$!%*#?&])[A-Za-z\d$@$!%*#?&]{8,}$", ErrorMessage = "Password should have minimum 8 characters at least 1 alphabet, 1 number and 1 special character")]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }
        
        [Required]
        [Display(Name = "Email address")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage="Please type a valid email address")]
        [DataType(DataType.EmailAddress, ErrorMessage= "Please type a valid email address")]
        public string Email { get; set; }
        
        [Required]
        [Display(Name = "First name")]
        [StringLength(150, ErrorMessage="Sorry your first name is too long to fit in the user list")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last name")]
        [StringLength(150, ErrorMessage = "Sorry your last name is too long to fit in the user list")]
        public string LastName { get; set; }


        [Display(Name = "Middle name")]
        [StringLength(150, ErrorMessage = "Sorry your middle name is too long to fit in the user list")]
        public string MiddleName { get; set; }

        [Required]
        [Display(Name = "Phone number")]
        [DisplayFormat(DataFormatString = "{0:# ###.###.####}")]
        [StringLength(20, ErrorMessage = "Sorry your middle name is too long to fit in the user list")]
        [DataType(DataType.PhoneNumber, ErrorMessage="Please type a valid phone number")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date, ErrorMessage="Please enter a valid Date.")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[$@$!%*#?&])[A-Za-z\d$@$!%*#?&]{8,}$", ErrorMessage = "Password should have minimum 8 characters at least 1 alphabet, 1 number and 1 special character")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class ExternalLogin
    {
        public string Provider { get; set; }
        public string ProviderDisplayName { get; set; }
        public string ProviderUserId { get; set; }
    }
}
