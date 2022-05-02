using Domain.Dtos.Usuario;
using Domain.Entities;

namespace Domain.Interfaces.Repositories.Usuario
{
    public interface IUsuarioRepository : IRepository<UsuarioEntity>
    {
        Task<UsuarioDto> GetCompleteById(Guid id);
    }
}
