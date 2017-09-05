using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GtecIt.ViewModels
{
    public class FornecedorIndexViewModel 
    {
        public FornecedorIndexViewModel()
        {
            Grid = new List<FornecedorGridViewModel>();
        }

        public int Codigo { get; set; }
        
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        public bool ConsultaTodos { get; set; }
        public List<FornecedorGridViewModel> Grid { get; set; }
    }
}