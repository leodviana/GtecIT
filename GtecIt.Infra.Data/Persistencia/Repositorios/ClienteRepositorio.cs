using System.Data.Entity;
using GtecIt.Domain.Entities;
using GtecIt.Infra.Data.Core.Interfaces;


namespace GtecIt.Infra.Data.Persistencia.Repositorios
{
    public class ClienteRepositorio : Repositorio<Cliente>, IClienteRepositorio
    {
         public ClienteRepositorio(DbContext context)
            : base(context)
        {
        }

        public GtecContext GtecContext
        {
            get { return Context as GtecContext; }
        }

        public void Salvar(Cliente entity)
        {
            throw new System.NotImplementedException();
        }

        public void Atualizar(Cliente entity)
        {
            throw new System.NotImplementedException();
        }

        public void RemoverPorId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
