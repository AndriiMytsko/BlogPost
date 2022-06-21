using AutoMapper;
using Entities.Models;
using Web.UseCases.Tag.DTOs;

namespace Web.UseCases.Tag.Mappings
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<TagEntity, TagDto>();
            CreateMap<CreateTagDto, TagEntity>();
            CreateMap<TagDto, TagEntity>();
        }
    }
}
