using System.Data.Entity.ModelConfiguration;
using GtecIt.Domain.Entities;

namespace GtecIt.Infra.Data.Persistencia.Mapeamento
{
    public class NotaEntradaItemConfiguration : EntityTypeConfiguration<NotaEntradaItem>
    {
        public NotaEntradaItemConfiguration()
        {
            
            // Primary Key
            this.HasKey(t => t.Codigo);

            // Properties
            this.Property(t => t.StatusEntrada)
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("stqentra", "dbgtec");
            this.Property(t => t.Codigo).HasColumnName("num_entrada");
            this.Property(t => t.CodigoNotaEntrada).HasColumnName("id_noten");
            this.Property(t => t.NumeroItem).HasColumnName("num_item");
            this.Property(t => t.CodigoAlmoxarifado).HasColumnName("cd_almox");
            this.Property(t => t.TipoEntrada).HasColumnName("tp_entrada");
            this.Property(t => t.DataEntrada).HasColumnName("dt_entrada");
            this.Property(t => t.CodigoProduto).HasColumnName("cd_produto");
            this.Property(t => t.QtdeEntrada).HasColumnName("qtd_entrada");
            this.Property(t => t.ValorTotal).HasColumnName("valor_total");
            this.Property(t => t.StatusEntrada).HasColumnName("status_entrada");
            this.Property(t => t.CodigoUsuario).HasColumnName("cd_usuario");

            // Relationships
            this.HasRequired(t => t.NotaEntrada)
                .WithMany(t => t.NotaItemEntradas)
                .HasForeignKey(d => d.CodigoNotaEntrada);
        }
    }
}
