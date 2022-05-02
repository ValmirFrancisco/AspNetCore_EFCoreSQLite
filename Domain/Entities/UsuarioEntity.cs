using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UsuarioEntity : BaseEntity
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        public string Email { get; set; }

        public List<PostEntity> Posts { get; set; }
    }
}
