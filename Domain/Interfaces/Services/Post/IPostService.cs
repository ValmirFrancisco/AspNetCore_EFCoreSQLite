using Domain.Dtos.Post;

namespace Domain.Interfaces.Services.Post
{
    public interface IPostService
    {
        Task<PostDto> Get(Guid id);
        Task<IEnumerable<PostDto>> GetAll();
        Task<PostCreateResultDto> Post(PostCreateDto postCreateDto);
        Task<PostUpdateResultDto> Put(PostUpdateDto postUpdateDto);
        Task<bool> Delete(Guid id);
    }
}
