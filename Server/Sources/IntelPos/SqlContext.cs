using Microsoft.EntityFrameworkCore;

namespace IntelPos
{
    public class SqlContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Box> Boxes { get; set; }

        public SqlContext() : base() { }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.HasDefaultSchema("intelpos");


            #region User
            {
                var user = builder.Entity<User>();
            }
            #endregion User


            #region Card
            {
                var card = builder.Entity<Card>();

                card.HasOne(c => c.Box)
                    .WithMany(b => b.Cards)
                    .OnDelete(DeleteBehavior.Cascade);
            }
            #endregion Card

            #region Box
            {
                var box = builder.Entity<Box>();
            }
            #endregion Box
        }
    }
}