using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zorb.Entidades;

namespace Zorb.Fronteiras.Repositorios
{
    public interface IChamadoRepositorio
    {
        Chamado Obter(long id);
        IEnumerable<Chamado> ListarTodos();
        void Salvar(Chamado chamado);
        void Atualizar(Chamado chamado);
    }
}
