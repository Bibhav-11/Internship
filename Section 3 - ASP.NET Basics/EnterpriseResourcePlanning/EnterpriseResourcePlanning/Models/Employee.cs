using Microsoft.Extensions.Primitives;

namespace EnterpriseResourcePlanning.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; } 
        public string FirstName { get; set; }   
        public string LastName { get; set; }    
        public string Email { get; set; }
        public int DepartmentId { get; set; }   //Foreign Key
        public Department Department { get; set; }  //Navigation Property
        public int JobTitleId { get; set; }     //Foreign Key
        public JobTitle JobTitle { get; set; }  //Navigation Property
    }
}
