using Domain.Dtos.Post;
using Domain.Interfaces.Services.Post;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_EFCoreInMemory.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PostsController : Controller
    {
        private readonly ILogger<PostsController> _logger;
        private readonly IConfiguration _configuration;
        private IPostService _service { get; set; }

        public PostsController(IPostService service, ILogger<PostsController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
            _service = service;
        }

        [HttpGet(Name = "GetPosts")]
        public async Task<IActionResult> Get()
        {
            var Posts = await _service.GetAll();

            var resposta = Posts.Select(u => new
            {
                id = u.Id,
                Conteudo = u.Conteudo,
                CreateAt = u.CreateAt,
                UpdateAt = u.UpdateAt,
                Usuario = u.Usuario.Nome
            });

            return Ok(resposta);
        }

        [HttpGet("{Id}", Name = "GetPostById")]
        public async Task<IActionResult> GetPostById(Guid Id)
        {
            var result = await _service.Get(Id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);

        }

        [HttpPost(Name = "CreatePost")]
        public async Task<IActionResult> CreatePost(PostCreateDto postCreateDto)
        {
            var result = await _service.Post(postCreateDto);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);

        }

        [HttpPost(Name = "UpdatePost")]
        public async Task<IActionResult> UpdatePost(PostUpdateDto postUpdateDto)
        {
            var result = await _service.Put(postUpdateDto);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);

        }

        [HttpDelete("{Id}", Name = "DeletePost")]
        public async Task<IActionResult> DeletePost(Guid Id)
        {
            var result = await _service.Delete(Id);

            if (!result)
            {
                return NotFound();
            }

            return Ok(result);

        }
    }
}
