using Microsoft.EntityFrameworkCore;

namespace CodingClub.Models
{
    public class CodingClubContext: DbContext
    {
        public CodingClubContext (DbContextOptions<CodingClubContext> options)
            : base(options)
        {
        }
        
        public DbSet<CodingClub.Models.Clients> Clients {get; set;}
    }
}