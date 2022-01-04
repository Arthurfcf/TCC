

using System.ComponentModel.DataAnnotations;

namespace ProjetoDDD.DOMAIN.Entity
{
  public  class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        public string  Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        
    }
}
