using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zorb.Fronteiras.Executores.Chamado.CriarChamado;
using Zorb.Fronteiras.Repositorios;
using Zorb.Persistencia;

namespace Zorb.ConfiguracaoDeDependencias
{
    public class Configuracao : NinjectModule
    {
        public override void Load()
        {
            Bind<IChamadoRepositorio>().To<ChamadoRepositorio>();
            Bind<IUsuarioRepositorio>().To<UsuarioRepositorio>();

            Bind<ICriarChamadoExecutor>().To<CriarChamadoExecutor>();
        }
    }
}
