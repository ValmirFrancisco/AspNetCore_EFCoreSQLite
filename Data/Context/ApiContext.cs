using Data.Mapping;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        { 
        }
        public DbSet<UsuarioEntity> Usuario { get; set; }
        public DbSet<PostEntity> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("User ID=ojkjtmjxuditvh;Password=8c7d59a0f3350d1dbcb3570ee04c7b62d49f90f2e31429e1e36b86045cc738ac;Host=ec2-34-230-153-41.compute-1.amazonaws.com;Port=5432;Database=de0geqb770oj2n;Pooling=true;Connection Lifetime=0;");
            }
        }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UsuarioEntity>(new UsuarioMap().Configure);

            modelBuilder.Entity<PostEntity>(new PostMap().Configure);

        }
    }
}
