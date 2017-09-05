using System;

namespace GtecIt.ViewModels
{
    public class NotaEntradaItemCreateViewModel 
    {
        public int Codigo { get; set; }
        public int CodigoNotaEntrada { get; set; }
        public int NumeroItem { get; set; }
        public int? CodigoAlmoxarifado { get; set; }
        public int TipoEntrada { get; set; }
        public DateTime? DataEntrada { get; set; }
        public int? CodigoProduto { get; set; }
        public decimal? QtdeEntrada { get; set; }
        public decimal? ValorTotal { get; set; }
        public string StatusEntrada { get; set; }
        public int? CodigoUsuario { get; set; }
        public  NotaEntradaEditViewModel NotaEntrada { get; set; }
    }
}