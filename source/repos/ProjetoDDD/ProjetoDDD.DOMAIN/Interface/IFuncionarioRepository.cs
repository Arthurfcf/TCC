
using ProjetoDDD.DOMAIN.Entity;
using System.Collections.Generic;

namespace ProjetoDDD.DOMAIN.Interface
{

    public interface IFuncionarioRepository : IRepositoryBase<Funcionario>
    {
        IEnumerable<Funcionario> Listagem();
        void Cadastrar(Funcionario funcionario);
        Funcionario BuscaFuncionario(int id);
        void Excluir(int id);
    }

   
}
