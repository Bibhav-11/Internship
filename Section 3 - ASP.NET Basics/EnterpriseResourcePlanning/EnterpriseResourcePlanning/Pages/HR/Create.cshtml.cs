using EnterpriseResourcePlanning.Data;
using EnterpriseResourcePlanning.DTO;
using EnterpriseResourcePlanning.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EnterpriseResourcePlanning.Pages.HR
{
    public class CreateModel : PageModel
    {
        private readonly ERPContext context;

        [BindProperty]
        public EmployeeDTO Employee { get; set; }

        public CreateModel(ERPContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            var department = await context.Departments.FirstOrDefaultAsync(d => d.Name == Employee.Department);
            if (department is null) ModelState.AddModelError("Employee.Department", "Cannot find the department");
            var title = await context.JobTitles.FirstOrDefaultAsync(t => t.JobTitleName == Employee.Title);
            if (title is null) ModelState.AddModelError("Employee.Title", "Cannot find the job title");

            if (!ModelState.IsValid) return Page();

            context.Employees.Add(new Employee
            {
                FirstName = Employee.FirstName,
                LastName = Employee.LastName,
                Email = Employee.Email,
                DepartmentId = department.DepartmentId,
                JobTitleId = title.JobTitleId
            });

            await context.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
