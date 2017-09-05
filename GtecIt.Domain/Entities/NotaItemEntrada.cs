using System;

namespace GtecIt.Domain.Entities
{
    public class NotaEntradaItem
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
        public virtual NotaEntrada NotaEntrada { get; set; }
    }
}
