
using ProjetoDDD.DOMAIN.Entity;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoDDD.Infra.Data.EntityConfig
{
    public class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
            HasKey(p => p.UsuarioId);
            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(50);

            Property(p => p.Email)
                .IsRequired();

        }
    }
}
