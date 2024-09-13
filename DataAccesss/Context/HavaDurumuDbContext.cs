using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccesss.Context
{
    public class HavaDurumuDbContext : DbContext
    {
        public HavaDurumuDbContext(DbContextOptions options) : base(options) 
        {
            
        }

        public DbSet<SehirHavaDurumu> SehirHavaDurumlari_TBL { get; set; }
    }
}
