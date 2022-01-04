

using ProjetoDDD.DOMAIN.Entity;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoDDD.Infra.Data.EntityConfig
{
  public class FuncionarioConfiguration : EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioConfiguration()
        {
            HasKey(c => c.FuncionarioId);
            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(50);
            Property(c => c.Valor)
                .IsRequired();
               
        }
    }
}
