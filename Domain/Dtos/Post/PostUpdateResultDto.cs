namespace Domain.Dtos.Post
{
    public class PostUpdateResultDto
    {
        public Guid Id { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        public string Conteudo { get; set; }

        public Guid UsuarioId { get; set; }

    }
}
