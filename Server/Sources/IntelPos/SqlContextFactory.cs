﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Text;

namespace IntelPos
{
    public class SqlContextFactory : IDesignTimeDbContextFactory<SqlContext>
    {
        public SqlContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SqlContext>().UseNpgsql(BuildPostgresConnectionString());

            return new SqlContext(builder.Options);
        }

        private static string BuildPostgresConnectionString()
        {
            var host = "178.154.212.96";
            var port = "5432";
            var db = "citylogia";
            var login = "citylogia";
            var password = "citylogia";

            var builder = new StringBuilder();

            builder.Append($"User ID={login};");
            builder.Append($"Password={password};");
            builder.Append($"Host={host};");

            if (int.TryParse(port, out var parsedPort))
            {
                builder.Append($"Port={parsedPort};");
            }

            builder.Append($"Database={db};");

            return builder.ToString();
        }
    }
}
