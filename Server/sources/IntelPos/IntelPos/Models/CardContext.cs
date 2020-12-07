using Microsoft.EntityFrameworkCore;

namespace IntelPos.Models
{
    public class CardContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }

        public CardContext (DbContextOptions<CardContext> options) : base(options)
        {
            // при отсутствии БД автоматически создает её
            Database.EnsureCreated();
        }
    }
}
