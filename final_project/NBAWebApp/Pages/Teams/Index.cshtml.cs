using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NBAWebApp.Models;
using NBAWebApp.Data;
using System.Collections.Generic;
using System.Linq;

namespace NBAWebApp.Pages.Teams
{
    public class IndexModel : PageModel
    {
        private readonly NBAContext _context;

        public IndexModel(NBAContext context)
        {
            _context = context;
        }

        public IList<Team> Teams { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SortOrder { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public void OnGet()
        {
            IQueryable<Team> teamsQuery = _context.teams;

            // 검색 로직
            if (!string.IsNullOrEmpty(SearchString))
            {
                teamsQuery = teamsQuery.Where(t => t.teamname.Contains(SearchString));
            }

            // 정렬 로직
            switch (SortOrder)
            {
                case "teamname":
                    teamsQuery = teamsQuery.OrderBy(t => t.teamname);
                    break;
                case "city":
                    teamsQuery = teamsQuery.OrderBy(t => t.city);
                    break;
                default:
                    teamsQuery = teamsQuery.OrderBy(t => t.teamid);
                    break;
            }

            Teams = teamsQuery.ToList();
        }
    }
}
