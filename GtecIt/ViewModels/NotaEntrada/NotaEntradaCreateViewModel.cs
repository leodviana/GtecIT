using System;
using System.Collections.Generic;

namespace GtecIt.ViewModels
{
    public class NotaEntradaCreateViewModel 
    {
        public int Codigo { get; set; }
        public int? TipoEntrada { get; set; }
        public DateTime? DataEntrada { get; set; }
        public int? CodigoFornecedor { get; set; }
        public int? CodigoAlmoxarife { get; set; }
        public int? CodigoCusto { get; set; }
        public int? NumeroNotaFiscal { get; set; }
        public string SerieNotaFiscal { get; set; }
        public DateTime? DataEmissaoNotaFiscal { get; set; }
        public int? TipoNota { get; set; }
        public string HistoricoNotaFiscal { get; set; }
        public int? CodigoUsuario { get; set; }
        public List<NotaEntradaItemEditViewModel> NotaItemEntradas { get; set; }
    }
}