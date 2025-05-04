using Microsoft.EntityFrameworkCore;
using NBAWebApp.Models; 

namespace NBAWebApp.Data
{
    public class NBAContext : DbContext
    {
        public NBAContext(DbContextOptions<NBAContext> options)
            : base(options)
        {
        }

        public DbSet<Team> teams { get; set; }  
        
    }
}

