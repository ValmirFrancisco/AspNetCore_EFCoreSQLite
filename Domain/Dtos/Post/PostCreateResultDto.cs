using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.Post
{
    public class PostCreateResultDto
    {
        public Guid Id { get; set; }

        public DateTime CreateAt { get; set; }

        public Guid UsuarioId { get; set; }

        public string Conteudo { get; set; }
    }
}
