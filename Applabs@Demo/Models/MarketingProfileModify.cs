using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Applabs_Demo.Models
{
    [MetadataType(typeof(MarketingProfileModify))]

public partial class Marketing
    {

    }
        public class MarketingProfileModify
    {
        [Display(Name="ID")]
        public int Id { get; set; }
        [Display(Name = "Employee Name")]
        [Required]
        public string Employee_Name { get; set; }
        [Display(Name = "Marketer Name")]
        [Required]
        public string Marketer_name { get; set; }
        [Display(Name = "Marketing Start Date")]
        [Required]
        [DataType(DataType.Date)]
        public System.DateTime Start_date { get; set; }
        [Display(Name = "Case Status")]
        [Required]
        public string case_status { get; set; }
        [Display(Name = "Case CLosed Date ")]
        
        public Nullable<System.DateTime> Close_date { get; set; }
    }
}