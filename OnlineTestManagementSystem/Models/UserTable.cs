//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;


    public partial class UserTable
    {
        public int User_Id { get; set; }

        [Required(ErrorMessage ="Required Field")]
        public string User_Name { get; set; }

        [Required(ErrorMessage = "Required Field")]
        [DataType(DataType.EmailAddress)]
        public string User_Email { get; set; }

        [Required(ErrorMessage = "Required Field")]
        [DataType(DataType.Password)]
        public string User_Password { get; set; }

        [Required(ErrorMessage = "Required Field")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Required Field")]
        public int Contact_Number { get; set; }
    }
}
