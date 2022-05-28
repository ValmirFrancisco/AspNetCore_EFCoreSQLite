using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<ApiContext>
    {
        public ApiContext CreateDbContext(string[] args)
        {
            //Usado para Criar as Migrações
            var connectionString = "User ID=ojkjtmjxuditvh;Password=8c7d59a0f3350d1dbcb3570ee04c7b62d49f90f2e31429e1e36b86045cc738ac;Host=ec2-34-230-153-41.compute-1.amazonaws.com;Port=5432;Database=de0geqb770oj2n;Pooling=true;Connection Lifetime=0;";
            var optionsBuilder = new DbContextOptionsBuilder<ApiContext>();
            // optionsBuilder.UseMySql(connectionString);
            //optionsBuilder.UseSqlServer(connectionString);
            optionsBuilder.UseNpgsql(connectionString);
            return new ApiContext(optionsBuilder.Options);
        }
    }
}
