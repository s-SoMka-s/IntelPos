using IntelPos.Models;
using Microsoft.EntityFrameworkCore;

namespace IntelPos
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }

        private const string host = "intelpos.postgres.database.azure.com";
        private const string port = "5432";
        private const string database = "IntelPos-dev";
        private const string userName = "postgre@intelpos";
        private const string password = "IntelPos2020";

        public ApplicationContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseNpgsql($"Host={host};Port={port};Database={database};Username={userName};Password={password};SslMode=Require");
        }
    }
}
