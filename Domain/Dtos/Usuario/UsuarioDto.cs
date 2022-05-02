using Domain.Dtos.Post;

namespace Domain.Dtos.Usuario
{
    public class UsuarioDto
    {
        public Guid Id { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public IEnumerable<PostDto> Posts { get; set; }
    }
}
