using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace crudtask2.Models
{
    public class DeptMeta
    {
        [Required]
        [Display(Name ="Department Id")]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Department Name")]
        public int Name { get; set; }
        [Required]
        [Display(Name = "Location")]
        public int Location { get; set; }


    }
    [MetadataType(typeof(DeptMeta))]
    public partial class Dept
    {

    }
       

}