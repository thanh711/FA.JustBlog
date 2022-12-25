using AutoMapper;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Models;

namespace FA.JustBlog.MapperConfig
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Post, PostVM>().ReverseMap();
            CreateMap<Tag, TagVM>().ReverseMap();
            CreateMap<Category, CategoryVM>().ReverseMap();
            CreateMap<Comment, CommentVM>().ReverseMap();
        }
    }
}
