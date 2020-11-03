using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
    public class Department
    {
        public long ID { get; set; }
        [Required(ErrorMessage = "Department Name is required.")]
        [DisplayName("Department Name")]
        public string DepartmentName { get; set; }
    }
}
