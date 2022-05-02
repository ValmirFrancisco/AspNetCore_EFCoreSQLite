using Domain.Dtos.Usuario;

namespace Domain.Dtos.Post
{
    public class PostDto
    {
        public Guid Id { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        public Guid UsuarioId { get; set; }

        public string Conteudo { get; set; }

        public UsuarioDto Usuario { get; set; }
    }
}
