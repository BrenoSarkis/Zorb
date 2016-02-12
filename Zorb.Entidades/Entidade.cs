using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zorb.Entidades
{
    public abstract class Entidade
    {
        public long Id { get; private set; }

        public override bool Equals(object obj)
        {
            var outraEntidade = obj as Entidade;

            if (ReferenceEquals(outraEntidade, null)) return false;

            if (ReferenceEquals(this, outraEntidade)) return true;

            if (this.GetType() != outraEntidade.GetType()) return false;

            if (Id == 0 || outraEntidade.Id == 0) return false;

            return this.Id == outraEntidade.Id;
        }

        public override int GetHashCode()
        {
            return (this.GetType().ToString() + Id).GetHashCode();
        }

        public static bool operator ==(Entidade entidade, Entidade outraEntidade)
        {
            if (ReferenceEquals(entidade, null) && ReferenceEquals(outraEntidade, null)) return true;

            if (ReferenceEquals(entidade, null) || ReferenceEquals(outraEntidade, null)) return false;

            return entidade.Equals(outraEntidade);
        }

        public static bool operator !=(Entidade entidade, Entidade outraEntidade)
        {
            return !(entidade == outraEntidade);
        }
    }
}
