using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.Usuario
{
    public class UsuarioCreateResultDto
    {
        public Guid Id { get; set; }

        public DateTime CreateAt { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }
    }
}
