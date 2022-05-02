using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PostEntity : BaseEntity
    {
        [Required]
        public Guid UsuarioId { get; set; }

        [Required]
        public string Conteudo { get; set; }

        [Required]
        public UsuarioEntity Usuario { get; set; }
    }
}
