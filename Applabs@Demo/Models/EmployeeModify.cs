using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Applabs_Demo.Models
{
    [MetadataType(typeof(EmployeeModify))]
    public partial class Employee
    {

    }    

    public class EmployeeModify
    {
        public int EmployeeID { get; set; }
        [Required]
        [Display(Name ="First Name")]
        public string First_Name { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string Last_Name { get; set; }
        [Required]
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public System.DateTime Date_of_Birth { get; set; }
        [Required]
        [Display(Name = "Passport Number")]
        public string Passport_Number { get; set; }
        [Required]
        [Display(Name = "Id Proof")]
        public bool Idproof { get; set; }
        [Required]
        [Display(Name = "Contact Number")]
        public string Contact_Number { get; set; }
        [Required]
        [Display(Name = "Permanent Address")]
        public string Permanent_Address { get; set; }
        
            [Display(Name = "Blood Group")]
        public string Blood_Group { get; set; }
        [Required]
        [Display(Name = "Qualificiation")]
        public string Qualification { get; set; }
        
        [Display(Name = "Technology")]
        public string Technology { get; set; }
        [Required]
        [Display(Name = "IS Internal Employee")]
        public bool Is_Internal_Employee { get; set; }
    }
}