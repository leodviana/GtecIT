﻿using System;
using System.Collections.Generic;

namespace GtecIt.Domain.Entities
{
    public class Orcamento
    {
        public int id_Stqcporcamento { get; set; }
        public DateTime? Dt_orcamento { get; set; }
        public int? id_grlcliente { get; set; }
        public int? Id_grldentista { get; set; }

        public int? id_grlconvenio { get; set; }
        public string Obs { get; set; }
        public int? cd_usuario { get; set; }
        public string status { get; set; }
        public virtual Cliente grlcliente { get; set; }
        public virtual Dentista grldentista { get; set; }

        public virtual Convenio Convenios { get; set; }

        
        public virtual ICollection<OrcamentoItem> itemorcamentos { get; set; }
        public virtual ICollection<Titulo> Titulos { get; set; }
    }
}
