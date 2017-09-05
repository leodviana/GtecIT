using System;
using System.Collections.Generic;

namespace GtecIt.ViewModels
{
    public class OrcamentoIndexViewModel 
    {
        public OrcamentoIndexViewModel()
        {
            Grid = new List<OrcamentoGridViewModel>();
        }

        public bool ConsultaTodos { get; set; }
        public int id_Stqcporcamento { get; set; }
        public DateTime? Dt_orcamento { get; set; }

        public int? id_grlcliente { get; set; }
        public int? Id_grldentista { get; set; }
        public string Obs { get; set; }
        public int? cd_usuario { get; set; }
        public string status { get; set; }

        public virtual ClienteEditViewModel clientes { get; set; }
        public virtual ConvenioEditViewModel Convenios { get; set; }
       
        public virtual DentistaEditViewModel dentistas { get; set; }
        public List<OrcamentoGridViewModel> Grid { get; set; }
        public virtual TituloEditViewModel titulos { get; set; }
       
    }
}