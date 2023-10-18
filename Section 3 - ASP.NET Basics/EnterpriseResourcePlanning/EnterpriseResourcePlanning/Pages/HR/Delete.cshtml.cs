using EnterpriseResourcePlanning.Data;
using EnterpriseResourcePlanning.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EnterpriseResourcePlanning.Pages.HR
{
    public class DeleteModel : PageModel
    {
        private readonly ERPContext context;

        public Employee Employee { get; set; }

        public DeleteModel(ERPContext context)
        {
            this.context = context;
        }
        public async Task OnGet(int id)
        {
            var employee =  await context.Employees.FirstOrDefaultAsync(employee => employee.EmployeeId == id);
            Employee = employee;
        }

        public async Task<IActionResult> OnPost(int id)
        {
            var employee = await context.Employees.FirstOrDefaultAsync(employee => employee.EmployeeId == id);
            context.Employees.Remove(employee);
            await context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
