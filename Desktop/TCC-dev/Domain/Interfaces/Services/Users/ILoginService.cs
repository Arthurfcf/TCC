using Domain.Dtos;
using Domain.Entidades;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.Users
{
    public interface ILoginService
    {
        Task<object> FindByLogin(UserEntity user);
    }
}
