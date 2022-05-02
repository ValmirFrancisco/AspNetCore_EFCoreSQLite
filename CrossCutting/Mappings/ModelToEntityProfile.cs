using AutoMapper;
using Domain.Entities;
using Domain.Models;

namespace CrossCutting.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            #region Usuario
            CreateMap<Usuario, UsuarioEntity>()
               .ReverseMap();
            #endregion

            #region Post
            CreateMap<Post, PostEntity>()
                .ReverseMap();
            #endregion
        }
    }
}
