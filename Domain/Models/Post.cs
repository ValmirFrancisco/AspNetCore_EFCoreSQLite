using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class Post : BaseModel
    {
        public Guid UsuarioId { get; set; }
        public string Conteudo { get; set; }
        public Usuario Usuario { get; set; }
    }
}
