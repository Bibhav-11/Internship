using EnterpriseResourcePlanning.Data;
using EnterpriseResourcePlanning.DTO;
using EnterpriseResourcePlanning.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EnterpriseResourcePlanning.Pages.HR
{
    public class EditModel : PageModel
    {
        private readonly ERPContext context;

        [BindProperty]
        public EmployeeDTO Employee { get; set; }

        public EditModel(ERPContext context)
        {
            this.context = context;
        }

        public async Task OnGet(int id)
        {
            var employee = await context.Employees.FirstOrDefaultAsync(employee => employee.EmployeeId == id);
            var department = await context.Departments.FirstOrDefaultAsync(d => d.DepartmentId == employee.DepartmentId);
            var title = await context.JobTitles.FirstOrDefaultAsync(t => t.JobTitleId == employee.JobTitleId);
            Employee = new EmployeeDTO
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email = employee.Email,
                Department = department.Name,
                Title = title.JobTitleName
            };
        }

        public async Task<IActionResult> OnPost(int id)
        {
            var department = await context.Departments.FirstOrDefaultAsync(d => d.Name == Employee.Department);
            if (department == null)
            {
                ModelState.AddModelError("Employee.Department", "Department not found");
            }

            var jobTitle = await context.JobTitles.FirstOrDefaultAsync(t => t.JobTitleName == Employee.Title);
            if (jobTitle == null)
            {
                ModelState.AddModelError("Employee.Title", "Job Position not found");
            }

            if (!ModelState.IsValid) return Page();


            var employee = await context.Employees.FirstOrDefaultAsync(employee => employee.EmployeeId == id);
            employee.FirstName = Employee.FirstName;
            employee.LastName = Employee.LastName;
            employee.Email = Employee.Email;
            employee.DepartmentId = department.DepartmentId;
            employee.JobTitleId = jobTitle.JobTitleId;

            await context.SaveChangesAsync();

            return RedirectToPage("Index");

        }
    }
}
