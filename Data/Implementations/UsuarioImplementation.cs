using Data.Context;
using Data.Repository;
using Domain.Dtos.Usuario;
using Domain.Entities;
using Domain.Interfaces.Repositories.Usuario;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementations
{
    public class UsuarioImplementation : BaseRepository<UsuarioEntity>, IUsuarioRepository
    {
        private DbSet<UsuarioEntity> _dataset;
        public UsuarioImplementation(ApiContext context) : base(context)
        {
            _dataset = context.Set<UsuarioEntity>();
        }
        public async Task<UsuarioEntity> FindByLogin(string email)
        {
            return await _dataset.FirstOrDefaultAsync(u => u.Email.Equals(email));
        }

        public Task<UsuarioDto> GetCompleteById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
