using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using NBAWebApp.Data;
using NBAWebApp.Models;

namespace NBAWebApp.Pages.Teams
{
    public class DetailsModel : PageModel
    {
        private readonly NBAContext _context;

        public DetailsModel(NBAContext context)
        {
            _context = context;
        }

        public Team team { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            team = await _context.teams.FirstOrDefaultAsync(m => m.teamid == id);

            if (team == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
