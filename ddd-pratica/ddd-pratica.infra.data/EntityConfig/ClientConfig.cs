using ddd_pratica.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ddd_pratica.infra.data.EntityConfig
{
    public class ClientConfig : EntityTypeConfiguration<Entities.Client>
    {
        public ClientConfig()
        {
            HasKey(c => c.ClientId);

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.LastName)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Email)
                .IsRequired();
        }
    }
}
