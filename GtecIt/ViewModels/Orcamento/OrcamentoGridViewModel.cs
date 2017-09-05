using System;
using System.Collections.Generic;

using GtecIt.Domain.Entities;

namespace GtecIt.ViewModels
{
    public class OrcamentoGridViewModel 
    {
        public int id_Stqcporcamento { get; set; }
        public DateTime? Dt_orcamento { get; set; }
        public int? id_grlcliente { get; set; }
        public int? Id_grldentista { get; set; }
        public string Obs { get; set; }
        public int? cd_usuario { get; set; }
        public string status { get; set; }
        public virtual ClienteEditViewModel grlcliente { get; set; }
        public virtual DentistaEditViewModel grldentista { get; set; }

        public virtual ICollection<Titulo> Titulos { get; set; }
        public virtual ConvenioEditViewModel Convenios { get; set; }
       
    }
}