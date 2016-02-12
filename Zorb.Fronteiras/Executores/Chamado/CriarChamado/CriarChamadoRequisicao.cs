using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zorb.Fronteiras.Executores.Chamado.CriarChamado
{
    public class CriarChamadoRequisicao
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataDeCriacao { get { return DateTime.Now; } }
        public long IdDoCriador { get; set; }
        public long IdDoResponsavel { get; set; }
    }
}
