

using ProjetoDDD.DOMAIN.Entity;
using System.Collections.Generic;

namespace ProjetoDDD.DOMAIN.Interface
{
  public  interface IUsuarioRepository : IRepositoryBase<Usuario>
    {
        IEnumerable<Usuario> BuscarProNome(string nome);
    }
}
