using System;
using System.Collections.Generic;

namespace ProjetoDDD.DOMAIN.Entity
{
  public  class Funcionario
    {
        public int FuncionarioId { get; set; }
        
        public string Nome { get; set; }
        
        public string Sobrenome { get; set; }

        public float Valor { get; set; }
    }
}
