using EnterpriseResourcePlanning.Data;
using EnterpriseResourcePlanning.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace EnterpriseResourcePlanning.Pages.HR
{
    [Authorize(Policy = "ForHROnly")]
    public class IndexModel : PageModel
    {
        private readonly ERPContext context;

        public IEnumerable<Employee> Employees { get; set; }

        public IndexModel(ERPContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
            Employees = context.Employees;

            foreach(var employee in Employees) { 
                var department = context.Departments.FirstOrDefault(d => d.DepartmentId == employee.DepartmentId);
                if (department is null) break;
                employee.Department = department;
                var jobTitle =  context.JobTitles.FirstOrDefault(t => t.JobTitleId == employee.JobTitleId);
                if (jobTitle is null) break;
                employee.JobTitle = jobTitle;   
            }
        }
    }
}
