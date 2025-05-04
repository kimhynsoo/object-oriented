using Microsoft.AspNetCore.Mvc.RazorPages;
using NBAWebApp.Models;

namespace NBAWebApp.Pages.Teams
{
    public class NewDetailModel : PageModel
    {
        public Team Team { get; set; } 

        public void OnGet()
        {
            
            Team = new Team();
        }
    }
}
