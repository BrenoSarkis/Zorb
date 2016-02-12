using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zorb.Entidades;

namespace Zorb.Fronteiras.Repositorios
{
    public interface IUsuarioRepositorio
    {
        Usuario Obter(long id);
        Usuario Obter(string nome);
    }
}
