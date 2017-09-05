using System.Data.Entity;
using GtecIt.Domain.Entities;
using GtecIt.Infra.Data.Core.Interfaces;
using GtecIt.Infra.Data.Persistencia;


namespace GtecIt.Infra.Data.Persistencia.Repositorios
{
    public class PedidoRepositorio :Repositorio<Pedido>, IPedidoRepositorio
    {
         public PedidoRepositorio(DbContext context)
            : base(context)
        {
        }

        public GtecContext GtecContext
        {
            get { return Context as GtecContext; }
        }

        public void Salvar(Pedido entity)
        {
            throw new System.NotImplementedException();
        }

        public void Atualizar(Pedido entity)
        {
            throw new System.NotImplementedException();
        }

        public void RemoverPorId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
