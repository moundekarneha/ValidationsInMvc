using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ValidationsInMvc.Models
{
    [Table("UserTable")]

    public class Register
    {
        [Key]

        [Required(ErrorMessage = "User id required")]

        public int Userid { get; set; }

        [StringLength(15, MinimumLength = 3, ErrorMessage = "User name should in 3 to 15 char")]

        public string username { get; set; }

        [DataType(DataType.Password)]
        public string pass { get; set; }

        [DataType(DataType.Password)]

        [Compare("pass", ErrorMessage = "Password Mismatch")]
        public string cpass { get; set; }

        [Range(15, 30, ErrorMessage = "Allow 15 to 30 only")]
        public int? age { get; set; }

        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [RegularExpression(@"\+91[0-9]{10}")]
        public string mobile { get; set; }
    }
}