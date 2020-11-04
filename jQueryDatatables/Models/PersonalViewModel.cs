using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jQueryDatatables.Models
{
    public class PersonalViewModel
    {
        public long ID { get; set; }
       
        public string FirstName { get; set; }
      
        public string LastName { get; set; }
    
        public Nullable<DateTime> DateOfBirth { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
     
        public string MobileNo { get; set; }
        public string NID { get; set; }
      
        public string Email { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string CreationUser { get; set; }
        public string LastUpdateUser { get; set; }
        public byte Status { get; set; }

        public string DepartmentName { get; set; }

        public long? DepartmentID { get; set; }
    }
}
