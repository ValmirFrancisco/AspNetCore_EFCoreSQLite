using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<UsuarioEntity>
    {
        public void Configure(EntityTypeBuilder<UsuarioEntity> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.Nome);

            builder.HasData(new UsuarioEntity()
                {
                    Id = new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"),
                    CreateAt = DateTime.Now,
                    Nome = "Araribóia Clayderman",
                    Email = "arariboia.claydeman@email.com"
                },
                new UsuarioEntity()
                {
                    Id = new Guid("7cc33300-586e-4be8-9a4d-bd9f01ee9ad8"),
                    CreateAt = DateTime.Now,
                    Nome = "Asdrúbal Moncorvo Filho",
                    Email = "asdrubal.moncorvo@email.com"
                },
                new UsuarioEntity
                {
                    Id = new Guid("cb9e6888-2094-45ee-bc44-37ced33c693a"),
                    CreateAt = DateTime.Now,
                    Nome = "Washington Ajefferson Clas Clay Souza",
                    Email = "washington.clay@aol.com"
                }
            );

            builder.HasMany(m => m.Posts);
        }
    }
}
