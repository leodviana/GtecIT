using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GtecIt.Infra.Data.Core;
using GtecIt.Infra.Data.Core.Interfaces;
using GtecIt.Infra.Data.Persistencia.Repositorios;


namespace GtecIt.Infra.Data.Persistencia
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GtecContext _context;

        public UnitOfWork(GtecContext context)
        {
            _context = context;


            TipoPagamentos = new TipoPagamentoRepositorio(_context);
            Bancos = new BancoRepositorio(_context);
            Cefalometrias = new CefalometriaRepositorio(_context);
            TipoTitulos = new TipoTituloRepositorio(_context);
            TipoTelefones = new TipoTelefoneRepositorio(_context);
            Sexos = new SexoRepositorio(_context);
            EstadoCivils = new EstadoCivilRepositorio(_context);
            Profissoes = new ProfissaoRepositorio(_context);
            Pessoas = new PessoaRepositorio(_context);
            Clientes = new ClienteRepositorio(_context);
            Dentistas = new DentistaRepositorio(_context);
            Convenios = new ConvenioRepositorio(_context);
            Enderecos = new EnderecoRepositorio(_context);
            Fornecedors = new FornecedorRepositorio(_context);
            NotaEntradas = new NotaEntradaRepositorio(_context);
            NotaEntradaItems = new NotaEntradaItemRepositorio(_context);
            Orcamentos = new OrcamentoRepositorio(_context);
            OrcamentoItens = new OrcamentoItemRepositorio(_context);
            Titulos = new TituloRepositorio(_context);
            Pedidos = new PedidoRepositorio(_context);
            PedidoItems = new PedidoItemRepositorio(_context);
            Grupos = new GrupoRepositorio(_context);
            SubGrupos = new SubGrupoRepositorio(_context);
            Produtos = new ProdutoRepositorio(_context);
            CefalometriaItems = new CefalometriaItemRepositorio(_context);
            Precos = new PrecoRepositorio(_context);
            Empresas = new EmpresaRepositorio(_context);
            Usuarios = new UsuarioRepositorio(_context);
            Relatorios = new RelatorioRepositorio(_context);

        }

        public ITipoPagamentoRepositorio TipoPagamentos { get; set; }
        public IBancoRepositorio Bancos { get; set; }
        public ICefalometriaRepositorio Cefalometrias { get; set; }
        public ITipoTituloRepositorio TipoTitulos { get; set; }
        public ITipoTelefoneRepositorio TipoTelefones { get; set; }
        public ISexoRepositorio Sexos { get; set; }
        public IEstadoCivilRepositorio EstadoCivils { get; set; }
        public IProfissaoRepositorio Profissoes { get; set; }
        public IPessoaRepositorio Pessoas { get; set; }
        public IClienteRepositorio Clientes { get; set; }
        public IDentistaRepositorio Dentistas { get; set; }
        public IConvenioRepositorio Convenios { get; set; }
        public IEnderecoRepositorio Enderecos { get; set; }
        public IFornecedorRepositorio Fornecedors { get; set; }
        public INotaEntradaRepositorio NotaEntradas { get; set; }
        public INotaEntradaItemRepositorio NotaEntradaItems { get; set; }
        public IOrcamentoRepositorio Orcamentos { get; set; }
        public IOrcamentoItemRepositorio OrcamentoItens { get; set; }
        public ITituloRepositorio Titulos { get; set; }
        public IPedidoRepositorio Pedidos { get; set; }
        public IPedidoItemRepositorio PedidoItems { get; set; }
        public IGrupoRepositorio Grupos { get; set; }
        public ISubGrupoRepositorio SubGrupos { get; set; }
        public IProdutoRepositorio Produtos { get; set; }
        public ICefalometriaItemRepositorio CefalometriaItems { get; set; }
        public IPrecoRepositorio Precos { get; set; }
        public IEmpresaRepositorio Empresas { get; set; }
        public IUsuarioRepositorio Usuarios { get; set; }
        public IRelatorioRepositorio Relatorios { get; set; }
        


        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
