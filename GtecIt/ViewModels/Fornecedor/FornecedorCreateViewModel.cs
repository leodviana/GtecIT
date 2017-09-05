using System.ComponentModel.DataAnnotations;

namespace GtecIt.ViewModels
{
    public class FornecedorCreateViewModel 
    {
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "*")]
        public string Nome { get; set; }
    }
}