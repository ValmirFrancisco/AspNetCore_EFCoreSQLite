using AutoMapper;
using Domain.Dtos.Post;
using Domain.Dtos.Usuario;
using Domain.Models;

namespace CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            #region Usuario
            CreateMap<Usuario, UsuarioDto>()
                    .ReverseMap();
            CreateMap<Usuario, UsuarioCreateDto>()
                    .ReverseMap();
            CreateMap<Usuario, UsuarioUpdateDto>()
                    .ReverseMap();
            #endregion

            #region Post
            CreateMap<Post, PostDto>()
                      .ReverseMap();
            CreateMap<Post, PostCreateDto>()
                    .ReverseMap();
            CreateMap<Post, PostUpdateDto>()
                    .ReverseMap();
            #endregion
        }
    }
}
