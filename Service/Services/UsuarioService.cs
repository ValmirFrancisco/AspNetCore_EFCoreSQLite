using AutoMapper;
using Domain.Dtos.Usuario;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services.Usuario;
using Domain.Models;

namespace Service.Services
{
    public class UsuarioService : IUsuarioService
    {
        private IRepository<UsuarioEntity> _repository;
        private readonly IMapper _mapper;

        public UsuarioService(IRepository<UsuarioEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<UsuarioDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<UsuarioDto>(entity);
        }

        public async Task<IEnumerable<UsuarioDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<UsuarioDto>>(listEntity);
        }

        public async Task<UsuarioCreateResultDto> Post(UsuarioCreateDto usuarioCreateDto)
        {
            var model = _mapper.Map<Usuario>(usuarioCreateDto);
            var entity = _mapper.Map<UsuarioEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<UsuarioCreateResultDto>(result);
        }

        public async Task<UsuarioUpdateResultDto> Put(UsuarioUpdateDto usuarioUpdateDto)
        {
            var model = _mapper.Map<Usuario>(usuarioUpdateDto);
            var entity = _mapper.Map<UsuarioEntity>(model);

            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<UsuarioUpdateResultDto>(result);
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
