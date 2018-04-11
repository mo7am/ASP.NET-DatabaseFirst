//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCWEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Orders = new HashSet<Order>();
            Image = "~/AppFiles/Images/default.png";
            Balance = 0.0;
        }


        [NotMapped]
        public HttpPostedFileBase ImageUpload { get; set; }

        public int UserID { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,100}$")]
        public string Fname { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,100}$")]
        public string Lname { get; set; }
        [Required]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "someone@example.com	Validates an e-mail address")]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{4,8}$", ErrorMessage = "Password must be at least 4 characters, no more than 8 characters, and must include at least one upper case letter, one lower case letter, and one numeric digit. Like --> Abcdef12")]
        public string Password { get; set; }
        //[Required]
        //[Compare("Password", ErrorMessage = "Confirm password doesn't match, Type again !")]
        public string ConfirmPassword { get; set; }
        //[Required]
        [RegularExpression(@"-?\d+(?:\.\d+)?")]
        public Nullable<double> Balance { get; set; }
        [Required] 
    [RegularExpression(@"(01)[0-9]{9}")]
    public string Phone { get; set; }
        public Nullable<int> TypeID { get; set; }
        public Nullable<int> StatusID { get; set; }
        public string Image { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,100}$")]
        public string Address { get; set; }

        public string CurrentPassword { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
        public virtual Status Status { get; set; }
        public virtual TypeUser TypeUser { get; set; }
    }
}
/*

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCWEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Orders = new HashSet<Order>();
            Image = "~/AppFiles/Images/default.png";
        }


        [NotMapped]
        public HttpPostedFileBase ImageUpload { get; set; }

        public int UserID { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$")]
        public string Fname { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$")]
        public string Lname { get; set; }
        [Required]
        [RegularExpression(@"^(?("")("".+?""@)|(([0 - 9a - zA - Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$", ErrorMessage = "someone@example.com	Validates an e-mail address")]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a - zA - Z0 - 9]{8,10})$", ErrorMessage = "It must be between 8 and 10 characters, contain at least one digit and one alphabetic character, and must not contain special characters")]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Confirm password doesn't match, Type again !")]
        public string ConfirmPassword { get; set; }
        [Required]
        [RegularExpression(@"^\d+(\.\d\d)?$")]
        public Nullable<double> Balance { get; set; }
        [Required]

        public string Phone { get; set; }
        [Required]
        [RegularExpression(@"")]
        public Nullable<int> TypeID { get; set; }
        [Required]
        [RegularExpression(@"")]
        public Nullable<int> StatusID { get; set; }
        public string Image { get; set; }
        [Required]

        public string Address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
        public virtual Status Status { get; set; }
        public virtual TypeUser TypeUser { get; set; }
    }
}
*/