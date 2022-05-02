using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.Usuario
{
    public class UsuarioCreateDto
    {
        [Required(ErrorMessage = "Nome de Usuário é obrigatório")]
        [StringLength(60, ErrorMessage = "Nome de Usuário deve ter no máximo {1} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Email é obrigatório")]
        [StringLength(60, ErrorMessage = "Email deve ter no máximo {1} caracteres.")]
        public string Email { get; set; }

    }
}
