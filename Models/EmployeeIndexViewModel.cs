using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paycompute.Models
{
    public class EmployeeIndexViewModel
    {
        public int Id { get; set; }
        public string EmployeeNo { get; set; }
        public string FirstName { get; set; }
       
        public string MiddleName { get; set; }
        
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string ImageURL { get; set; }

        public DateTime Dob { get; set; }
        public DateTime DateJoined { get; set; }
        public string Designation { get; set; }

        public string Email { get; set; }
        
        public string Address { get; set; }
        
        public string City { get; set; }
        
        public string PostCode { get; set; }

        }
}
