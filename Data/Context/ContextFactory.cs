using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<ApiContext>
    {
        public ApiContext CreateDbContext(string[] args)
        {
            //Usado para Criar as Migrações
            var connectionString = "Data Source=UsersPosts.db";
            var optionsBuilder = new DbContextOptionsBuilder<ApiContext>();
            // optionsBuilder.UseMySql(connectionString);
            //optionsBuilder.UseSqlServer(connectionString);
            optionsBuilder.UseSqlite(connectionString);
            return new ApiContext(optionsBuilder.Options);
        }
    }
}
