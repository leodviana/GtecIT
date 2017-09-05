using System.Collections.Generic;

namespace GtecIt.ViewModels
{
    public class NotaEntradaIndexViewModel 
    {
        public NotaEntradaIndexViewModel()
        {
            Grid = new List<NotaEntradaGridViewModel>();
        }

        public bool ConsultaTodos { get; set; }
        public int NumeroNotaFiscal { get; set; }
        public List<NotaEntradaGridViewModel> Grid { get; set; }
    }
}