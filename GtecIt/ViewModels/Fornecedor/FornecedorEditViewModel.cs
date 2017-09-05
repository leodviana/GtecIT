using System.ComponentModel.DataAnnotations;

namespace GtecIt.ViewModels
{
    public class FornecedorEditViewModel 
    {
        public int Codigo { get; set; }
        
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "*")]
        public string Nome { get; set; }
    }
}