using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationsDemo
{
    //Datat Annotation is used to configure a model class
    //Annotation attribute are used to apply to class or classes member to specify the 
    //the relationship between classes describe how the data is display in the ui and specified 
    //validatation both.
    internal class AnnotationTest
    {
        public void EmployeeObj() 
        {

            Employee emp = new Employee();
            emp.Name = "Pikachu";
            emp.Age = 200;
            emp.EmailId = "123456789@yahoo.c";
            emp.ContactNymber = "Amit Kumar";
            ValidationContext valid = new ValidationContext(emp);
            List<ValidationResult> list = new List<ValidationResult>();
            bool verify=Validator.TryValidateObject(emp, valid,list,true);
            if (!verify)
            {
                foreach(ValidationResult result in list)
                {
                    Console.WriteLine("MemberNames {0}",result.MemberNames.First(),Environment.NewLine);
                    Console.WriteLine("MemberNames {0}{1}",result.ErrorMessage,Environment.NewLine);
                }
                
            }
            else
            {
                Console.WriteLine("Name: {0}",emp.Name);
                Console.WriteLine("Age: {0}",emp.Age);
                Console.WriteLine("Email_Id: {0}",emp.EmailId);
                Console.WriteLine("Contact Number: {0}", emp.ContactNymber);
            }
                
        
        }

    }
}
