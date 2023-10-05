using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationsDemo
{
    internal class Employee
    {
        [Required(ErrorMessage = "Employee {0} is required")] //Attribute
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Name should be minimum 4 character " +
            "and maximum 100 character")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage ="Name should be only in Alphabet")]
        //[DataType(DataType.Text)]
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailId { get; set; }
        [Range(18,105,ErrorMessage="Age should be above 18 and below 105")]
        public int Age { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string ContactNymber { get; set; }
        
    }
}
