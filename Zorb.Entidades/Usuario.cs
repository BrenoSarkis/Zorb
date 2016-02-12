using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zorb.Entidades
{
    public class Usuario : Entidade
    {
        public Usuario(string nome, string login, string senha)
        {

        }

        public string Nome { get; private set; }
        public string Login { get; private set; }
        public string Senha { get; private set; }
    }
}
