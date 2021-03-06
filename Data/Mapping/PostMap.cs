using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class PostMap : IEntityTypeConfiguration<PostEntity>
    {
        public void Configure(EntityTypeBuilder<PostEntity> builder)
        {
            builder.ToTable("Posts");

            builder.HasKey(u => u.Id);

            builder.HasOne(m => m.Usuario)
                .WithMany(n => n.Posts);

        }
    }
}
