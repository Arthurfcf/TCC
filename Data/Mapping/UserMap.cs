using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("User");

            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.Email)
                .IsUnique();
            builder.Property(u => u.Email)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(50);
            
        }
    }
}
