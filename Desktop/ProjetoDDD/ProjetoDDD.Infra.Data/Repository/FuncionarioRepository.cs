using ProjetoDDD.DOMAIN.Entity;
using ProjetoDDD.DOMAIN.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Infra.Data.Repository
{
  public  class FuncionarioRepository : RepositoryBase<Funcionario>, IFuncionarioRepository
    {
    }
}
