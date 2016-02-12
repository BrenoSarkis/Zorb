using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zorb.Fronteiras.Executores.Chamado.CriarChamado
{
    public interface ICriarChamadoExecutor
    {
        void Executar(CriarChamadoRequisicao requisicao);
    }
}
