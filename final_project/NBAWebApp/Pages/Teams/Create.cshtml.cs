using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using NBAWebApp.Data;
using NBAWebApp.Models;


    public class CreateModel : PageModel
    {
        private readonly NBAContext _context;

        public CreateModel(NBAContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Team team { get; set; }

        public void OnGet()
        {
            // 초기화 작업
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.teams.Add(team);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Teams/Index");
        }
    }

