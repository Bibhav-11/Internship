using EnterpriseResourcePlanning.Data;
using EnterpriseResourcePlanning.DTO;
using EnterpriseResourcePlanning.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace EnterpriseResourcePlanning.Pages.Login
{
    public class IndexModel : PageModel
    {
        private readonly ERPContext _context;

        [BindProperty]
        public LoginDTO Credential { get; set; }

        public IndexModel(ERPContext context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            if (User.Identity.IsAuthenticated) return RedirectToPage("/Index");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if(!ModelState.IsValid) { return Page();  }

            var user = _context.Users.FirstOrDefault(user => user.UserName == Credential.UserName);
            if(user == null)
            {
                ModelState.AddModelError("Credential.UserName", "No user exists with the Username you've provided");
                return Page();
            }

            if(user.Password != Credential.Password)
            {
                ModelState.AddModelError("Credential.Password", "Sorry, the password you've provided is not correct.");
                return Page();
            }

            //Create a security context
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.FirstName),
                new Claim(ClaimTypes.Role, user.Role),
                new Claim(ClaimTypes.Email, user.Email)
            };

            var claimsIdentity = new ClaimsIdentity(claims, "CustomCookie");
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

            await HttpContext.SignInAsync("CustomCookie", claimsPrincipal);

            return RedirectToPage("/HR/Index");

        }


    }
}
