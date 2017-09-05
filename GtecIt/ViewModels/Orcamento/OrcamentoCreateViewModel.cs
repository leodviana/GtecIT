using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GtecIt.ViewModels
{
    public class OrcamentoCreateViewModel 
    {
        public OrcamentoCreateViewModel()
        {
            Dropdownconvenio = new List<SelectListItem>();
        }

        public int id_Stqcporcamento { get; set; }
        public DateTime? Dt_orcamento { get; set; }
        public int? id_grlcliente { get; set; }
        public string CodigoCliente { get; set; }
        public string NomeCliente { get; set; }

        public string NomeDentista { get; set; }

        public string  NomeConvenio { get; set; }

        public int? Id_grldentista { get; set; }
        public string Obs { get; set; }
        public int? cd_usuario { get; set; }
        public string status { get; set; }
        public int? id_grlconvenio { get; set; }
        public virtual ConvenioEditViewModel Convenios { get; set; }


        public List<SelectListItem> Dropdownconvenio { get; set; }
        public virtual TituloEditViewModel titulos { get; set; }
    }
}