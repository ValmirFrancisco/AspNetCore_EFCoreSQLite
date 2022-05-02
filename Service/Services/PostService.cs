using AutoMapper;
using Domain.Dtos.Post;
using Domain.Dtos.Usuario;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services.Post;
using Domain.Models;

namespace Service.Services
{
    public class PostService : IPostService
    {
        private IRepository<PostEntity> _repository;
        private readonly IMapper _mapper;

        public PostService(IRepository<PostEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<PostDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<PostDto>(entity);
        }

        public async Task<IEnumerable<PostDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<PostDto>>(listEntity);
        }

        public async Task<PostCreateResultDto> Post(PostCreateDto postCreateDto)
        {
            var model = _mapper.Map<Post>(postCreateDto);
            var entity = _mapper.Map<PostEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<PostCreateResultDto>(result);
        }

        public async Task<PostUpdateResultDto> Put(PostUpdateDto postUpdateDto)
        {
            var model = _mapper.Map<Post>(postUpdateDto);
            var entity = _mapper.Map<PostEntity>(model);

            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<PostUpdateResultDto>(result);
        }
    }
}
