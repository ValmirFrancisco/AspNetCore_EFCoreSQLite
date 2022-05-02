using Domain.Dtos.Usuario;

namespace Domain.Interfaces.Services.Usuario
{
    public interface IUsuarioService
    {
        Task<UsuarioDto> Get(Guid id);
        Task<IEnumerable<UsuarioDto>> GetAll();
        Task<UsuarioCreateResultDto> Post(UsuarioCreateDto usuarioCreateDto);
        Task<UsuarioUpdateResultDto> Put(UsuarioUpdateDto usuarioUpdateDto);
        Task<bool> Delete(Guid id);
    }
}
