using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace crudtask2.Models
{
    public class Studentmeta
    {
        [Display(Name = " Id")]
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Mobile Number")]
        public string PhNo { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Display(Name = "Birthdate")]
        [DataType(DataType.Date)]
        
        public Nullable<System.DateTime>  Dob { get; set; }
    [Display(Name = "Address")]
    public string Address { get; set; }
    [Display(Name = "Gender")]
    public string Gender { get; set; }
        [Display(Name = "Dept Name")]
        public Nullable<int> DeptId { get; set; }
        public virtual depart depart { get; set; }
    }
    [MetadataType(typeof(Studentmeta))]
    public partial class student { }
}