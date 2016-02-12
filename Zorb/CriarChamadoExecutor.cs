using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zorb.Entidades;
using Zorb.Fronteiras.Executores.Chamado.CriarChamado;
using Zorb.Fronteiras.Repositorios;

namespace Zorb
{
    public class CriarChamadoExecutor : ICriarChamadoExecutor
    {
        private readonly IChamadoRepositorio chamadoRepositorio;
        private readonly IUsuarioRepositorio usuarioRepositorio;

        public CriarChamadoExecutor(IChamadoRepositorio chamadoRepositorio, IUsuarioRepositorio usuarioRepositorio)
        {
            this.chamadoRepositorio = chamadoRepositorio;
            this.usuarioRepositorio = usuarioRepositorio;
        }

        public void Executar(CriarChamadoRequisicao requisicao)
        {
            var criador = this.usuarioRepositorio.Obter(requisicao.IdDoCriador);
            var responsavel = this.usuarioRepositorio.Obter(requisicao.IdDoResponsavel);
            var chamado = new Chamado(requisicao.Titulo, requisicao.Descricao, requisicao.DataDeCriacao, criador, responsavel);
            this.chamadoRepositorio.Salvar(chamado);
        }
    }
}

public abstract class T
{
    public abstract string Z { get; set; }
}
