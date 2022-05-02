using AutoMapper;
using Domain.Dtos.Post;
using Domain.Dtos.Usuario;
using Domain.Entities;

namespace CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            #region Usuario
            CreateMap<UsuarioDto, UsuarioEntity>()
               .ReverseMap();

            CreateMap<UsuarioCreateResultDto, UsuarioEntity>()
               .ReverseMap();

            CreateMap<UsuarioUpdateResultDto, UsuarioEntity>()
               .ReverseMap();
            #endregion

            #region Post
            CreateMap<PostDto, PostEntity>()
                .ReverseMap();

            CreateMap<PostCreateResultDto, PostEntity>()
               .ReverseMap();

            CreateMap<PostUpdateResultDto, PostEntity>()
               .ReverseMap();
            #endregion
        }
    }
}
