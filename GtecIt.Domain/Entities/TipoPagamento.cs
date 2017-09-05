using System.Collections.Generic;

namespace GtecIt.Domain.Entities
{
    public partial class TipoPagamento
    {
        public TipoPagamento()
        {
        }

        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Titulo> Titulos { get; set; }
    }
}
