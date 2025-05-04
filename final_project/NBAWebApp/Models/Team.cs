using System.ComponentModel.DataAnnotations;

namespace NBAWebApp.Models 
{
    public class Team
    {
        [Required]
        public int teamid { get; set; }  

        [Required]
        [StringLength(100)]
        public string teamname { get; set; }  

        [Required]
        [StringLength(100)]
        public string city { get; set; }   
    }
}
