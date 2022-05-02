using System.ComponentModel.DataAnnotations;

namespace Domain.Dtos.Post
{
    public class PostUpdateDto
    {
        [Required(ErrorMessage = "Id é campo Obrigatorio")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Id de Usuário é obrigatório")]
        public Guid UsuarioId { get; set; }

        [Required(ErrorMessage = "Conteúdo é obrigatório")]
        [StringLength(1000, ErrorMessage = "Conteúdo deve ter no máximo {1} caracteres.")]
        public string Conteudo { get; set; }
    }
}
