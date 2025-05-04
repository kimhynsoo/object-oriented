using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using NBAWebApp.Data;
using NBAWebApp.Models;

namespace NBAWebApp.Pages.Teams
{
    public class EditModel : PageModel
    {
        private readonly NBAContext _context;

        public EditModel(NBAContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Team team { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            team = await _context.teams.FindAsync(id);

            if (team == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(team).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeamExists(team.teamid))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("/Teams/Index");
        }

        private bool TeamExists(int id)
        {
            return _context.teams.Any(e => e.teamid == id);
        }
    }
}
