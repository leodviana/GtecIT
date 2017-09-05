using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace GtecIt.ViewModels
{
    public class PessoaCreateViewModel 
    {
        public PessoaCreateViewModel()
        {
            EstadoCivil = new List<EstadoCivilEditViewModel>();
            Tipo01 = new List<TipoTelefoneEditViewModel>();
            DropdownIdentifica = new List<SelectListItem>();
            DropdownSexo = new List<SelectListItem>();
            DropdownEstado = new List<SelectListItem>();
        }



        public long orcamentoid { get; set; }

        public bool OrcamentoEmAndamento { get; set; }


        public bool OrcamentoEmAndamentoedicao { get; set; }

        public bool OrcamentoEmAndamentodentista { get; set; }

        public bool Dentista { get; set; }

        public bool Usuario { get; set; }

        public int Id_grlbasico { get; set; }
        [Required(ErrorMessage = "*")]
        public string nome { get; set; }

        public string razao_social { get; set; }
        public string Nome_fantasia { get; set; }


        public int sexo { get; set; }
         [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime? dt_nascimento { get; set; }
        public int? Id_grlprofi { get; set; }
        public int? Id_grlcidad { get; set; }
        public int? Id_grlcivil { get; set; }

        
        public string cgc { get; set; }
        
        public string insc_municipal { get; set; }
        public string insc_estadual { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string contato { get; set; }
        public string ddd_telefone { get; set; }
        public int? Id_grlidtel { get; set; }
        public string ddd_telefone2 { get; set; }
        public int? Id_grlidtel02 { get; set; }
        public string email { get; set; }
        public string Email2 { get; set; }

        private int? _Id_grlcdusu = 1;

        public int? Id_grlcdusu
        {
            get { return _Id_grlcdusu; }
            set { _Id_grlcdusu = value; } 
        }

        public string Id_grltopessoa { get; set; }


        public string status { get; set; }

        public IEnumerable<SelectListItem> DropDownTipoPessoa
        {
            get
            {
                var lst = new List<SelectListItem>
                {
                    new SelectListItem {Text = "Física", Value = "F"},
                    new SelectListItem {Text = "Jurídica", Value = "J"}
                };
                return lst;
            }
        }

        public List<SelectListItem> DropdownIdentifica { get; set; }

        public List<SelectListItem> DropdownSexo { get; set; }

        public List<SelectListItem> DropdownEstado { get; set; }

        public List<EstadoCivilEditViewModel> EstadoCivil { get; set; }

        public List<TipoTelefoneEditViewModel> Tipo01 { get; set; }

    }
}