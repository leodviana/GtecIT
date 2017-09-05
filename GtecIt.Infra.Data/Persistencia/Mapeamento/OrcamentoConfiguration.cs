﻿using System.Data.Entity.ModelConfiguration;
using GtecIt.Domain.Entities;

namespace GtecIt.Infra.Data.Persistencia.Mapeamento
{
    public class OrcamentoConfiguration : EntityTypeConfiguration<Orcamento>
    {
        
            public OrcamentoConfiguration()
            {
                this.HasKey(t => t.id_Stqcporcamento);

                // Properties
                this.Property(t => t.Obs)
                    .HasMaxLength(45);

                this.Property(t => t.status)
                    .HasMaxLength(1);

                // Table & Column Mappings
                this.ToTable("stqcporcamento", "dbgtec_2");
                this.Property(t => t.id_Stqcporcamento).HasColumnName("id_Stqcporcamento");
                this.Property(t => t.Dt_orcamento).HasColumnName("Dt_orcamento");
                this.Property(t => t.id_grlcliente).HasColumnName("id_grlcliente");
                this.Property(t => t.Id_grldentista).HasColumnName("Id_grldentista");
                this.Property(t => t.Obs).HasColumnName("Obs");
                this.Property(t => t.cd_usuario).HasColumnName("cd_usuario");
                this.Property(t => t.status).HasColumnName("status");
                this.Property(t => t.id_grlconvenio).HasColumnName("id_grlconvenio");

                // Relationships
                this.HasOptional(t => t.grlcliente)
                    .WithMany(t => t.Orcamentos)
                    .HasForeignKey(d => d.id_grlcliente);
                this.HasOptional(t => t.grldentista)
                    .WithMany(t => t.Orcamentos)
                    .HasForeignKey(d => d.Id_grldentista);

                this.HasOptional(t => t.Convenios)
               .WithMany(t => t.Orcamentos)
               .HasForeignKey(d => d.id_grlconvenio);
               
            }
      }
    }

