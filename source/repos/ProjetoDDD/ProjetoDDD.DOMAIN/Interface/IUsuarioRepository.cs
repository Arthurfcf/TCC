

using ProjetoDDD.DOMAIN.Entity;
using System.Collections.Generic;

namespace ProjetoDDD.DOMAIN.Interface
{
  public  interface IUsuarioRepository : IRepositoryBase<Usuario>
    {
        IEnumerable<Usuario> Listagem();
        Usuario BuscaUsuario(Usuario usuario);
        void Cadastrar(Usuario usuario);
        void Excluir(int id);
    }
}
