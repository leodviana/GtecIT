using AutoMapper;
using GtecIt.Domain.Entities;
using GtecIt.ViewModels;

namespace GtecIt.App_Start
{
    public class AutoMapperConfig
    {
        public static void RegistrarMapeamentos()
        {
            Mapper.CreateMap<TipoPagamento, TipoPagamentoIndexViewModel>().ReverseMap();
            Mapper.CreateMap<TipoPagamento, TipoPagamentoGridViewModel>().ReverseMap();
            Mapper.CreateMap<TipoPagamento, TipoPagamentoEditViewModel>().ReverseMap();
            Mapper.CreateMap<TipoPagamento, TipoPagamentoCreateViewModel>().ReverseMap();

            Mapper.CreateMap<TipoTitulo, TipoTituloIndexViewModel>().ReverseMap();
            Mapper.CreateMap<TipoTitulo, TipoTituloGridViewModel>().ReverseMap();
            Mapper.CreateMap<TipoTitulo, TipoTituloEditViewModel>().ReverseMap();
            Mapper.CreateMap<TipoTitulo, TipoTituloCreateViewModel>().ReverseMap();


            Mapper.CreateMap<TipoTelefone, TipoTelefoneIndexViewModel>().ReverseMap();
            Mapper.CreateMap<TipoTelefone, TipoTelefoneGridViewModel>().ReverseMap();
            Mapper.CreateMap<TipoTelefone, TipoTelefoneEditViewModel>().ReverseMap();
            Mapper.CreateMap<TipoTelefone, TipoTelefoneCreateViewModel>().ReverseMap();

            Mapper.CreateMap<Sexo, SexoIndexViewModel>().ReverseMap();
            Mapper.CreateMap<Sexo, SexoGridViewModel>().ReverseMap();
            Mapper.CreateMap<Sexo, SexoEditViewModel>().ReverseMap();
            Mapper.CreateMap<Sexo, SexoCreateViewModel>().ReverseMap();

            Mapper.CreateMap<Profissao, ProfissaoIndexViewModel>().ReverseMap();
            Mapper.CreateMap<Profissao, ProfissaoGridViewModel>().ReverseMap();
            Mapper.CreateMap<Profissao, ProfissaoEditViewModel>().ReverseMap();
            Mapper.CreateMap<Profissao, ProfissaoCreateViewModel>().ReverseMap();

            Mapper.CreateMap<EstadoCivil, EstadoCivilIndexViewModel>().ReverseMap();
            Mapper.CreateMap<EstadoCivil, EstadoCivilGridViewModel>().ReverseMap();
            Mapper.CreateMap<EstadoCivil, EstadoCivilEditViewModel>().ReverseMap();
            Mapper.CreateMap<EstadoCivil, EstadoCivilCreateViewModel>().ReverseMap();


            Mapper.CreateMap<Grupo, GrupoIndexViewModel>().ReverseMap();
            Mapper.CreateMap<Grupo, GrupoGridViewModel>().ReverseMap();
            Mapper.CreateMap<Grupo, GrupoEditViewModel>().ReverseMap();
            Mapper.CreateMap<Grupo, GrupoCreateViewModel>().ReverseMap();

            Mapper.CreateMap<SubGrupo, SubGrupoIndexViewModel>().ReverseMap();
            Mapper.CreateMap<SubGrupo, SubGrupoGridViewModel>().ReverseMap();
            Mapper.CreateMap<SubGrupo, SubGrupoEditViewModel>().ReverseMap();
            Mapper.CreateMap<SubGrupo, SubGrupoCreateViewModel>().ReverseMap();


            Mapper.CreateMap<Produto, ProdutoIndexViewModel>().ReverseMap();
            Mapper.CreateMap<Produto, ProdutoGridViewModel>().ReverseMap();
            Mapper.CreateMap<Produto, ProdutoEditViewModel>().ReverseMap();
            Mapper.CreateMap<Produto, ProdutoCreateViewModel>().ReverseMap();

            Mapper.CreateMap<Pessoa, PessoaIndexViewModel>().ReverseMap();
            Mapper.CreateMap<Pessoa, PessoaGridViewModel>().ReverseMap();
            Mapper.CreateMap<Pessoa, PessoaEditViewModel>().ReverseMap();
            Mapper.CreateMap<Pessoa, PessoaCreateViewModel>().ReverseMap();
            Mapper.CreateMap<Pessoa, PessoaViewModel>().ReverseMap();
            Mapper.CreateMap<Pessoa, PessoaSimpleViewModel>().ReverseMap();

            Mapper.CreateMap<Endereco, EnderecoIndexViewModel>().ReverseMap();
            Mapper.CreateMap<Endereco, EnderecoGridViewModel>().ReverseMap();
            Mapper.CreateMap<Endereco, EnderecoEditViewModel>().ReverseMap();
            Mapper.CreateMap<Endereco, EnderecoCreateViewModel>().ReverseMap();


            Mapper.CreateMap<NotaEntrada, NotaEntradaIndexViewModel>().ReverseMap();
            Mapper.CreateMap<NotaEntrada, NotaEntradaGridViewModel>().ReverseMap();
            Mapper.CreateMap<NotaEntrada, NotaEntradaEditViewModel>().ReverseMap();
            Mapper.CreateMap<NotaEntrada, NotaEntradaCreateViewModel>().ReverseMap();

            Mapper.CreateMap<Fornecedor, FornecedorIndexViewModel>().ReverseMap();
            Mapper.CreateMap<Fornecedor, FornecedorGridViewModel>().ReverseMap();
            Mapper.CreateMap<Fornecedor, FornecedorEditViewModel>().ReverseMap();
            Mapper.CreateMap<Fornecedor, FornecedorCreateViewModel>().ReverseMap();

            Mapper.CreateMap<NotaEntradaItem, NotaEntradaItemCreateViewModel>().ReverseMap();
            Mapper.CreateMap<NotaEntradaItem, NotaEntradaItemEditViewModel>().ReverseMap();

            Mapper.CreateMap<Pedido, PedidoIndexViewModel>().ReverseMap();
            Mapper.CreateMap<Pedido, PedidoGridViewModel>().ReverseMap();
            Mapper.CreateMap<Pedido, PedidoEditViewModel>().ReverseMap();
            Mapper.CreateMap<Pedido, PedidoCreateViewModel>().ReverseMap();

            Mapper.CreateMap<PedidoItem, PedidoItemCreateViewModel>().ReverseMap();
            Mapper.CreateMap<PedidoItem, PedidoItemEditViewModel>().ReverseMap();


            Mapper.CreateMap<Orcamento, OrcamentoIndexViewModel>().ReverseMap();
            Mapper.CreateMap<Orcamento, OrcamentoGridViewModel>().ReverseMap();
            Mapper.CreateMap<Orcamento, OrcamentoEditViewModel>().ReverseMap();
            Mapper.CreateMap<Orcamento, OrcamentoCreateViewModel>().ReverseMap();


            Mapper.CreateMap<OrcamentoItem, OrcamentoItemIndexViewModel>().ReverseMap();
            Mapper.CreateMap<OrcamentoItem, OrcamentoItemGridViewModel>().ReverseMap();
            Mapper.CreateMap<OrcamentoItem, OrcamentoItemEditViewModel>().ReverseMap();
            Mapper.CreateMap<OrcamentoItem, OrcamentoItemCreateViewModel>().ReverseMap();

            Mapper.CreateMap<Cliente, ClienteIndexViewModel>().ReverseMap();
            Mapper.CreateMap<Cliente, ClienteGridViewModel>().ReverseMap();
            Mapper.CreateMap<Cliente, ClienteEditViewModel>().ReverseMap();
            Mapper.CreateMap<Cliente, ClienteCreateViewModel>().ReverseMap();

            Mapper.CreateMap<Dentista, DentistaIndexViewModel>().ReverseMap();
            Mapper.CreateMap<Dentista, DentistaGridViewModel>().ReverseMap();
            Mapper.CreateMap<Dentista, DentistaEditViewModel>().ReverseMap();
            Mapper.CreateMap<Dentista, DentistaCreateViewModel>().ReverseMap();

            Mapper.CreateMap<Titulo, TituloIndexViewModel>().ReverseMap();
            Mapper.CreateMap<Titulo, TituloGridViewModel>().ReverseMap();
            Mapper.CreateMap<Titulo, TituloEditViewModel>().ReverseMap();
            Mapper.CreateMap<Titulo, TituloCreateViewModel>().ReverseMap();


            Mapper.CreateMap<Banco, BancoIndexViewModel>().ReverseMap();
            Mapper.CreateMap<Banco, BancoGridViewModel>().ReverseMap();
            Mapper.CreateMap<Banco, BancoEditViewModel>().ReverseMap();
            Mapper.CreateMap<Banco, BancoCreateViewModel>().ReverseMap();

            Mapper.CreateMap<Convenio, ConvenioIndexViewModel>().ReverseMap();
            Mapper.CreateMap<Convenio, ConvenioGridViewModel>().ReverseMap();
            Mapper.CreateMap<Convenio, ConvenioEditViewModel>().ReverseMap();
            Mapper.CreateMap<Convenio, ConvenioCreateViewModel>().ReverseMap();

            Mapper.CreateMap<Cefalometria, CefalometriaIndexViewModel>().ReverseMap();
            Mapper.CreateMap<Cefalometria, CefalometriaGridViewModel>().ReverseMap();
            Mapper.CreateMap<Cefalometria, CefalometriaEditViewModel>().ReverseMap();
            Mapper.CreateMap<Cefalometria, CefalometriaCreateViewModel>().ReverseMap();

            Mapper.CreateMap<CefalometriaItem, CefalometriaItemIndexViewModel>().ReverseMap();
            Mapper.CreateMap<CefalometriaItem, CefalometriaItemGridViewModel>().ReverseMap();
            Mapper.CreateMap<CefalometriaItem, CefalometriaItemEditViewModel>().ReverseMap();
            Mapper.CreateMap<CefalometriaItem, CefalometriaItemCreateViewModel>().ReverseMap();

            Mapper.CreateMap<Preco, PrecoIndexViewModel>().ReverseMap();
            Mapper.CreateMap<Preco, PrecoGridViewModel>().ReverseMap();
            Mapper.CreateMap<Preco, PrecoEditViewModel>().ReverseMap();
            Mapper.CreateMap<Preco, PrecoCreateViewModel>().ReverseMap();

            Mapper.CreateMap<Usuario, UsuarioCreateViewModel>().ReverseMap();
            Mapper.CreateMap<Usuario, UsuarioEditViewModel>().ReverseMap();
            Mapper.CreateMap<Usuario, UsuarioGridViewModel>().ReverseMap();
            Mapper.CreateMap<Usuario, UsuarioLogadoViewModel>().ReverseMap();
           // Mapper.CreateMap<Usuario, UsuarioSimpleViewModel>().ReverseMap();*/
            Mapper.CreateMap<Usuario, UsuarioIndexViewModel>().ReverseMap();

            Mapper.CreateMap<Empresa, EmpresaIndexViewModel>().ReverseMap();
            Mapper.CreateMap<Empresa, EmpresaGridViewModel>().ReverseMap();
            Mapper.CreateMap<Empresa, EmpresaEditViewModel>().ReverseMap();
            Mapper.CreateMap<Empresa, EmpresaCreateViewModel>().ReverseMap();
            Mapper.CreateMap<Empresa, EmpresaLogadoViewModel>().ReverseMap();

           /* Mapper.CreateMap<Relatorio, RelatorioIndexViewModel>().ReverseMap();
            Mapper.CreateMap<Relatorio, RelatorioGridViewModel>().ReverseMap();
            Mapper.CreateMap<Relatorio, RelatorioEditViewModel>().ReverseMap();
            Mapper.CreateMap<Relatorio, RelatorioCreateViewModel>().ReverseMap();*/
        }
    }
}