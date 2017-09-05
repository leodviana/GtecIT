using System.Data.Entity;
using GtecIt.Domain.Entities;
using GtecIt.Infra.Data.Core.Interfaces;


namespace GtecIt.Infra.Data.Persistencia.Repositorios
{
    public class NotaEntradaItemRepositorio :Repositorio<NotaEntradaItem>, INotaEntradaItemRepositorio
    {
         public NotaEntradaItemRepositorio(DbContext context)
            : base(context)
        {
        }

        public GtecContext GtecContext
        {
            get { return Context as GtecContext; }
        }

        public void Salvar(NotaEntradaItem entity)
        {
            throw new System.NotImplementedException();
        }

        public void Atualizar(NotaEntradaItem entity)
        {
            throw new System.NotImplementedException();
        }

        public void RemoverPorId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
