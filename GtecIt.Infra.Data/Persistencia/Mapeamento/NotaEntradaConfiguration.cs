using System.Data.Entity.ModelConfiguration;
using GtecIt.Domain.Entities;

namespace GtecIt.Infra.Data.Persistencia.Mapeamento
{
    public class NotaEntradaConfiguration : EntityTypeConfiguration<NotaEntrada>
    {
        public NotaEntradaConfiguration()
        {
            // Primary Key
            this.HasKey(t => t.Codigo);

            // Properties
            this.Property(t => t.SerieNotaFiscal)
                .HasMaxLength(4);

            this.Property(t => t.HistoricoNotaFiscal)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("stqnoten", "dbgtec");
            this.Property(t => t.Codigo).HasColumnName("id_noten");
            this.Property(t => t.TipoEntrada).HasColumnName("tp_entrada");
            this.Property(t => t.DataEntrada).HasColumnName("dt_entrada");
            this.Property(t => t.CodigoFornecedor).HasColumnName("cd_fornecedor");
            this.Property(t => t.CodigoAlmoxarife).HasColumnName("cd_almox");
            this.Property(t => t.CodigoCusto).HasColumnName("cd_ccusto");
            this.Property(t => t.NumeroNotaFiscal).HasColumnName("num_nf");
            this.Property(t => t.SerieNotaFiscal).HasColumnName("serie_nf");
            this.Property(t => t.DataEmissaoNotaFiscal).HasColumnName("dt_emissao_nf");
            this.Property(t => t.TipoNota).HasColumnName("tp_nota");
            this.Property(t => t.HistoricoNotaFiscal).HasColumnName("historico_nf");
            this.Property(t => t.CodigoUsuario).HasColumnName("cd_usuario");
        }
    }
}
