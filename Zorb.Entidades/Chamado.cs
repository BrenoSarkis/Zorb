using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zorb.Entidades
{
    public class Chamado : Entidade
    {
        protected Chamado() { }

        public Chamado(string titulo, string descricao, DateTime dataDeCriacao, Usuario criador, Usuario responsavel = null)
        {
            Titulo = titulo;
            Descricao = descricao;
            Criador = criador;
            Responsavel = responsavel;
        }

        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public DateTime DataDeCriacao { get; private set; }
        public DateTime? DataDeConclusao { get; private set; }
        public Usuario Criador { get; private set; }
        public Usuario Responsavel { get; set; }
    }
}
