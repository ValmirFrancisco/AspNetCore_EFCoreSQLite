using Domain.Dtos.Usuario;
using Domain.Interfaces.Services.Usuario;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_EFCoreInMemory.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UsuariosController : ControllerBase
    {
        private readonly ILogger<UsuariosController> _logger;
        private readonly IConfiguration _configuration;
        private IUsuarioService _service { get; set; }

        public UsuariosController(IUsuarioService service, ILogger<UsuariosController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
            _service = service;
        }

        [HttpGet(Name = "GetUsuarios")]
        public async Task<IActionResult> Get()
        {
            //var usuarios = await _context.Usuarios
            //                     .Include(u => u.Posts)
            //                     .ToArrayAsync();

            var usuarios = await _service.GetAll();

            var resposta = usuarios.Select(u => new
            {
                id = u.Id,
                nome = u.Nome,
                email = u.Email,
                CreateAt = u.CreateAt,
                UpdateAt = u.UpdateAt,
                posts = u.Posts.Select(p => p.Conteudo)
            });

            return Ok(resposta);
        }

        [HttpGet("{Id}", Name = "GetUserById")]
        public async Task<IActionResult> GetUserById(Guid Id)
        {
            var result = await _service.Get(Id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);

        }

        [HttpPost(Name = "CreateUser")]
        public async Task<IActionResult> CreateUser(UsuarioCreateDto usuarioCreateDto)
        {
            var result = await _service.Post(usuarioCreateDto);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);

        }

        [HttpPost(Name = "UpdateUser")]
        public async Task<IActionResult> UpdateUser(UsuarioUpdateDto usuarioUpdateDto)
        {
            var result = await _service.Put(usuarioUpdateDto);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);

        }

        [HttpDelete("{Id}", Name = "DeleteUser")]
        public async Task<IActionResult> DeleteUser(Guid Id)
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
