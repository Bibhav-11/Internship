namespace EnterpriseResourcePlanning.Models
{
    public static class SampleData
    {
        public static List<Employee> employees = new List<Employee>()
        {
            new Employee
            {
                EmployeeId = 1,
                JobTitleId = 1,
                DepartmentId = 1,
                FirstName = "Bibhav",
                LastName = "Lamichhane",
                Email = "bibhav.25@gmail.com"
            },
            new Employee
            {
                EmployeeId = 2,
                JobTitleId = 2,
                DepartmentId = 1,
                FirstName = "John",
                LastName = "Smith",
                Email = "john.smith@gmail.com"
            }
        };

        public static List<Department> departments = new List<Department>()
        {
            new Department { DepartmentId = 1, Name  = "Technology"}
        };

        public static List<JobTitle> jobTitles = new List<JobTitle>()
        {
            new JobTitle {JobTitleId = 1, JobTitleName = "Intern", Salary = 15000m},
        };
    }
}
