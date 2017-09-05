using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GtecIt.ViewModels
{
    public class OrcamentoEditViewModel 
    {
        public OrcamentoEditViewModel()
        {
            itemorcamentos = new List<OrcamentoItemEditViewModel>();
            titulos = new List<TituloEditViewModel>();
            Dropdownconvenio = new List<SelectListItem>();
        }
        public int id_Stqcporcamento { get; set; }
        public DateTime? Dt_orcamento { get; set; }
        public int? id_grlcliente { get; set; }
        public int? id_grlconvenio { get; set; }
        public string nomecliente { get; set; }
    
        public int? Id_grldentista { get; set; }
        public string nomedentista { get; set; }
        public string Obs { get; set; }
        public int? cd_usuario { get; set; }
        public string status { get; set; }

        public List<SelectListItem> Dropdownconvenio { get; set; }

        public virtual ClienteEditViewModel grlcliente { get; set; }
        public virtual DentistaEditViewModel grldentista { get; set; }

        public virtual ConvenioEditViewModel Convenios { get; set; }
       
        public virtual List<OrcamentoItemEditViewModel> itemorcamentos { get; set; }
        public virtual List<TituloEditViewModel> titulos { get; set; }


        public bool guia { get; set; }
    }
}