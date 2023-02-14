using ddd_pratica.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddd_pratica.infra.data.EntityConfig
{
    public class ProductConfig : EntityTypeConfiguration<Product>
    {
        public ProductConfig()
        {
            HasKey(p => p.ProductId);

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(250);

            Property(p => p.Price)
               .IsRequired();

            HasRequired(p => p.Client)
                .WithMany()
                .HasForeignKey(p => p.ClientId);

        }
    }
}
